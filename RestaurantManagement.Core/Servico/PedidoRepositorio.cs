﻿
using RestaurantManagement.Core.Modelos;

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

        public static void AdicionarPedido(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }
    }
}
