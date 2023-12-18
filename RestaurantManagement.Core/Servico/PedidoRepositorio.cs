
using RestaurantManagement.Core.Modelos.Pagamentos;

namespace RestaurantManagement.Core.Servico
{
    internal class PedidoRepositorio
    {
        private static List<Pedido> _pedidos = new List<Pedido>();

        public static List<Pedido> Pedidos()
        {
            return _pedidos;
        }

        public static void ExibirPedidos()
        {
            Console.WriteLine("Pedidos:");
            foreach (var pedido in Pedidos())
            {
                Console.WriteLine(pedido.ToString() + "\n");
            }
        }
    }
}
