using System;
using System.Collections.Generic;

using RestaurantManagement.Core.Modelos;
using RestaurantManagement.Core.Modelos.Mesas;
using RestaurantManagement.Core.Modelos.ItensCardapio;


namespace RestaurantManagement.Core.Modelos
{
    internal class Pedido
    {
        public string Id { get; private set; }
        private List<ItemPedido> _itensPedidos;
        private readonly Pagamento _Pagamento;
        private bool _foiEntregue;
        private Mesa _mesa;
        private bool _foiPago;

        public Pedido(Mesa mes)
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

        public void PagarPedido(Pagamento formaDePagamento)
        {
            if (_foiPago)
            {
                throw new InvalidOperationException("O pedido já foi pago.");
            }

            _pagamento = formaDePagamento;
            _foiPago = true;
            _Pagamento.LiberarPagamento();
        }

        public override string ToString()
        {
            return $"Pedido {Id}{ExibirItensPedido()}";
        }

        private string ExibirItensPedido()
        {
            string strItensPedido = "";
            foreach (var item in _itensPedidos)
            {
                strItensPedido += $"\nProduto: {produto.Nome} - Quantidade: {quantidade}";
            }
            return strItensPedido;
        }
    }
}