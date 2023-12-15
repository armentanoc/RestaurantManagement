using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagement.Core.Modelos.Pedido;
using RestaurantManagement.Core.Modelos.Enum;

namespace RestaurantManagement.Core.Modelos.Pagamento
{
    internal class Pagamento
    {
        private Pedido _pedido;
        public string _id { get; set; }
        private bool _foiPago;
        private decimal _valorTotal;
        private TipoPagamento _tipoPagamento;

        public Pagamento(Pedido pedido, TipoPagamento tipoPagamento)
        {
            _pedido = pedido;
            _id = _pedido.id;
            _tipoPagamento = tipoPagamento;
        }


    }
}
