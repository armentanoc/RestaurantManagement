using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model
{
    internal class Pedido
    {
        private List<Tuple<Item, int>> _itensPedidos;
        private Mesa mesa;
        private bool _foiEntregue;
        private Pagamento pagamento;

        public Pedido(Mesa mesa)
        {
            this.mesa = mesa;
        }

        public void AdicionarItens(Item item, int quantidade)
        {
            _itensPedidos.Add(new Tuple<Item, int>(item, quantidade));
        }
    }
}
