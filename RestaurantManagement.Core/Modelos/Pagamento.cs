using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagement.Core.Modelos.Enum;

namespace RestaurantManagement.Core.Modelos
{
    internal class Pagamento
    {
        public string id { get; set; }
        private Pedido _pedido;
        private bool _foiPago;
        private decimal _valorTotal;
        private TipoPagamento _tipoPagamento;

        public Pagamento(Pedido pedido, TipoPagamento tipoPagamento)
        {
            _pedido = pedido;
            id = _pedido.id;
            _tipoPagamento = tipoPagamento;
        }


    }
}
