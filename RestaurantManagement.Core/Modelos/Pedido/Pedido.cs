using RestaurantManagement.Core.Modelos.Mesas;
using RestaurantManagement.Core.Modelos.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pedido
{
    internal class Pedido
    {
        public string id { get; set; }
        private List<Tuple<Item, int>> _itensPedidos;
        private Mesa _mesa;
        private bool _foiEntregue;
        private Pagamento _pagamento;

        public Pedido(Mesa mesa)
        {
            id = Guid.NewGuid().ToString();
            _mesa = mesa;
            _foiEntregue = false;
        }

        public void AdicionarItens(Item item, int quantidade)
        {
            _itensPedidos.Add(new Tuple<Item, int>(item, quantidade));
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
