using System;
using System.Collections.Generic;

using RestaurantManagement.Core.Modelos.Mesas;
using RestaurantManagement.Core.Modelos.ItensCardapio;
using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Servico;
using RestaurantManagement.ConsoleInteraction;
using System.Globalization;


namespace RestaurantManagement.Core.Modelos
{
    internal class Pedido
    {
        public string Id { get; private set; }
        private List<ItemPedido> _itensPedidos;
        public Pagamento? _Pagamento { get; private set; }
        private bool _foiEntregue;
        private Mesa _mesa;
        private bool _foiPago;
        public decimal ValorTotal {  get; private set; }

        public Pedido(Mesa mesa)
        {
            Id = Guid.NewGuid().ToString();
            _mesa = mesa;
            _foiEntregue = false;
            _itensPedidos = new List<ItemPedido>();
            _foiPago = false;
        }
        public void AdicionarItens(Produto item, int quantidade)
        {
            if (_foiPago)
            {
                throw new InvalidOperationException("Não é possível adicionar itens a um pedido que já foi pago.");
            }

            _itensPedidos.Add(new ItemPedido(item, quantidade));
        }
        public void EntregarPedido()
        {
            _foiEntregue = true;
        }
        public Mesa GetMesa()
        {
            return _mesa;
        }
        public void FecharConta()
        {
            _Pagamento = new Pagamento(this);
            PagamentoRepositorio.Pagamentos().Add(_Pagamento);
            Console.WriteLine(ExibirConta());
            _Pagamento.SetValorTotal(CalcularValorTotal());
            Console.WriteLine($"\nTotal: {_Pagamento.ValorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        }
        private string ExibirConta()
        {
            string strItensPedido = $"\nMesa: {_mesa.Numero}";
            foreach (var item in _itensPedidos)
            {
                strItensPedido += $"\n\nProduto: {item.Produto.Nome} " +
                    $"\nValor Unitário: {item.Produto.Preco.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} " +
                    $"\nQuantidade: {item.Quantidade}" +
                    $"\nSubtotal: {item.ValorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}";
            }

            return strItensPedido;
        }
        private decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach (var item in _itensPedidos)
            {
                valorTotal += item.CalcularValorTotal();
            }
            return valorTotal;
        }
        public void ProcessarPagamento()
        {

            string[] menuOpcoes = System.Enum.GetNames(typeof(TipoPagamento))
                .Concat(new[] { "Voltar" }).ToArray();

            Menu opcoes = new Menu(menuOpcoes);

            while (true)
            {
                Console.Clear();
                int selecaoGerente = opcoes.ExibirMenu(Titulo.OlaGerente());
                if (selecaoGerente == (menuOpcoes.Length - 1))
                {
                    Console.WriteLine("Retornando ao menu anterior...");
                    return;
                }
                else
                {
                    if (_foiPago)
                    {
                        Console.WriteLine("O pedido já foi pago.");
                        return;
                    } 
                    else
                    {
                        _Pagamento.SetTipoPagamento(menuOpcoes[selecaoGerente]);
                        this._foiPago = true;
                        Console.WriteLine($"Pagamento processado.");
                        _mesa.LiberarMesa();
                        Console.WriteLine($"Mesa {_mesa.Numero} liberada.");
                        AtualizarRepositorioDePagamentos(this._Pagamento, _foiPago);
                        return;
                    }
                }
            }
        }
        private void AtualizarRepositorioDePagamentos(Pagamento pagamento, bool foiPago)
        {
            var pagamentos = PagamentoRepositorio.Pagamentos();
            var index = pagamentos.FindIndex(p => p.Id == pagamento.Id);
            if (index != -1)
            {
                pagamento.SetFoiPago(foiPago);  
                pagamentos[index] = pagamento;
            }
        }
        private string ExibirItensPedido()
        {
            string strItensPedido = $"\nMesa: {_mesa.Numero}";
            foreach (var item in _itensPedidos)
            {
                strItensPedido += $"\nProduto: {item.Produto.Nome}" +
                    $" - Quantidade: {item.Quantidade}";
            }
            
            return strItensPedido;
        }
        public override string ToString()
        {
            return $"\nPedido {Id}{ExibirItensPedido()}";
        }
    }
}