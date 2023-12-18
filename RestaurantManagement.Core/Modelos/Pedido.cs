using System;
using System.Collections.Generic;

namespace RestaurantManagement.Core.Modelos.Mesas
{
    internal class Pedido
    {
        public string Id { get; private set; }
        private List<Tuple<dynamic, int>> _itensPedidos;
        private readonly Mesa _mesa;
        private bool _foiEntregue;
        private Pagamento _pagamento;
        private bool _foiPago;

        public Pedido(Mesa mesa)
        {
            Id = Guid.NewGuid().ToString();
            _mesa = mesa;
            _foiEntregue = false;
            _itensPedidos = new List<Tuple<dynamic, int>>();
            _foiPago = false;
        }

        public void AdicionarItens(dynamic item, int quantidade)
        {
            if (_foiPago)
            {
                throw new InvalidOperationException("Não é possível adicionar itens a um pedido que já foi pago.");
            }

            _itensPedidos.Add(new Tuple<dynamic, int>(item, quantidade));
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
            _mesa.LiberarMesa();
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
                (dynamic produto, int quantidade) = item;
                strItensPedido += $"\nProduto: {produto.Nome} - Quantidade: {quantidade}";
            }
            return strItensPedido;
        }
    }
}