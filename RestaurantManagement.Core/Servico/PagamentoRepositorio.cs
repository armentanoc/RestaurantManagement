using RestaurantManagement.Core.Modelos.Pagamentos;
using RestaurantManagement.Core.Modelos;


namespace RestaurantManagement.Core.Servico
{
    internal class PagamentoRepositorio
    {
        private static List<Pagamento> _pagamentos = new List<Pagamento>();

        public static List<Pagamento> Pagamentos()
        {
            return _Pagamentos;
        }

        public static void ExibirPagamentos()
        {
            Console.WriteLine("Pagamentos:");

            foreach (var Pagamento in Pagamentos())
            {
                Console.WriteLine(Pagamento.ToString());
            }
        }
         
    }
}
