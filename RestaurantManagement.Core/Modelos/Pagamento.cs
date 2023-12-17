
using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Modelos.Mesas;

namespace RestaurantManagement.Core.Modelos
{
    internal class Pagamento
    {
        public string Id { get; set; }
        private Pedido _pedido;
        private bool _foiPago;
        private decimal _valorTotal;
        private TipoPagamento _tipoPagamento;

        public Pagamento(Pedido pedido, TipoPagamento tipoPagamento)
        {
            _pedido = pedido;
            Id = _pedido.Id;
            _tipoPagamento = tipoPagamento;
        }
    }
}
