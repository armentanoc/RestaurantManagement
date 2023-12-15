using RestaurantManagement.Core.Modelos.Mesas;

namespace RestaurantManagement.Core.Modelos
{
    internal class Pedido
    {
        public string id { get; set; }
        private List<Tuple<dynamic, int>> _itensPedidos;
        private Mesa _mesa;
        private bool _foiEntregue;
        private Pagamento _pagamento;

        public Pedido(Mesa mesa)
        {
            id = Guid.NewGuid().ToString();
            _mesa = mesa;
            _foiEntregue = false;
        }

        public void AdicionarItens(dynamic item, int quantidade)
        {
            _itensPedidos.Add(new Tuple<dynamic, int>(item, quantidade));
        }

        public void EntregarPedido()
        {
            _foiEntregue = true;
        }

        public void PagarPedido(Pagamento formaDePagamento)
        {
            throw new NotImplementedException();
        }
    }
}
