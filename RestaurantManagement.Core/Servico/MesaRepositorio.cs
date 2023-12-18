using RestaurantManagement.Core.Modelos.Mesas;

namespace RestaurantManagement.Core.Servico
{
    internal class MesaRepositorio
    {
        private static List<Mesa> _mesas = new List<Mesa>
        {
            new Mesa(1, 4, true),
            new Mesa(2, 4, true),
            new Mesa(3, 2, true),
            new Mesa(4, 2, true),
            new Mesa(5, 4, false),
            new Mesa(6, 4, false),
            new Mesa(7, 2, false),
            new Mesa(8, 2, false)
        };

        public static List<Mesa> Mesas()
        {
            return _mesas;
        }

        public static void ExibirMesas()
        {
            Console.WriteLine("Mesas:");

            foreach (var mesa in Mesas())
            {
                Console.WriteLine("\n" + mesa.ToString());
            }
        }

        public static List<Mesa> MesasDisponiveis()
        {
            return _mesas.Where(mesa => mesa.EstaOcupada == false).ToList();
        }

        public static List<Mesa> MesasOcupadas()
        {
            return _mesas.Where(mesa => mesa.EstaOcupada == true).ToList();
        }

        public static void AlocarClientesNaMesa(Mesa mesa)
        {
            if (_mesas.Contains(mesa))
            {
                mesa.AlocarClientes();
                AtualizarMesaNaLista(mesa);
            }
            else
            {
                Console.WriteLine("Mesa não encontrada na lista.");
            }
        }

        private static void AtualizarMesaNaLista(Mesa mesa)
        {
            int index = _mesas.FindIndex(m => m.Numero == mesa.Numero);
            if (index != -1)
            {
                _mesas[index] = mesa;
            }
        }
    }
}
