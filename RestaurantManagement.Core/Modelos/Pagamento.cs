
using RestaurantManagement.Core.Modelos.Enum;
using System.Globalization;

namespace RestaurantManagement.Core.Modelos
{
    internal class Pagamento
    {
        public string Id { get; set; }
        public Pedido Pedido { get; }
        public bool FoiPago { get; private set; }
        public decimal ValorTotal { get; private set; }
        private TipoPagamento _tipoPagamento;

        public Pagamento(Pedido pedido)
        {
            Pedido = pedido;
            Id = Pedido.Id;
            ValorTotal = Pedido.ValorTotal;
        }
        public void SetFoiPago(bool b)
        {
            FoiPago = b;
        }

        internal void SetValorTotal(decimal valorTotalPedidos)
        {
            ValorTotal = valorTotalPedidos;
        }

        internal void SetTipoPagamento(string tipoPagamento)
        {
            if (System.Enum.TryParse<TipoPagamento>(tipoPagamento, out TipoPagamento parsedTipoPagamento))
            {
                _tipoPagamento = parsedTipoPagamento;
            }
            else
            {
                Console.WriteLine("Tipo de pagamento inválido.");
            }
        }
        public override string ToString()
        {
            string foiPago = (FoiPago) ? ("APROVADO") : ("AGUARDANDO");
            return $"\nPagamento {Id} referente ao pedido {Pedido.Id}| Status: {foiPago}\nValor total: {ValorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} | Tipo de pagamento: {_tipoPagamento}\n";

        }
    }
}
