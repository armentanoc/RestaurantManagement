
using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Modelos.Mesas;

namespace RestaurantManagement.Core.Modelos
{
    internal class Pagamento
    {
        public string Id { get; set; }
        public Pedido Pedido { get; }
        public bool FoiPago { get; }
        public decimal ValorTotal { get; }
        private TipoPagamento _tipoPagamento;

        public Pagamento(Pedido pedido, TipoPagamento tipoPagamento)
        {
            _pedido = pedido;
            Id = _pedido.Id;
            _tipoPagamento = tipoPagamento;
            this.ValorTotal = pedido.ValorTotal;
        }

        public void ConfirmarPagamento()
        {
            this.FoiPago = true;
        }

        public override string ToString() 
        {
            string foiPago = (FoiPago) ? ("APROVADO") : ("AGUARDANDO");
            return $"Pagamento {Id}\n  referente ao pedido {Pedido.Id}| Status: {foiPago}\nValor total: R$ {ValorTotal} | {_tipoPagamento}\n";

        }
    }
}
