
using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core.Servico
{
    internal class FuncionarioRepositorio
    {
        public static List<Funcionario> Funcionarios()
        {
            return new List<Funcionario>
        {
            new Garcom("Carol", "carol", 7000),
            new Garcom("Paula", "paula", 7000),
            new Gerente("Vitória", "vitoria", 12000)
        };
        } 
        public static void ExibirFuncionarios()
        {
            Console.WriteLine("Funcionários:");

            foreach (var funcionario in Funcionarios())
            {
                Console.WriteLine("\n" + funcionario.ToString());
            }
        }
    }
}
