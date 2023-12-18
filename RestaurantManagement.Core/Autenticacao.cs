
using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core
{
    internal static class Autenticacao
    {
        public static Funcionario? RealizarAutenticacao(List<Funcionario> funcionarios)
        {
            Console.Write("Digite o login: ");
            string login = Console.ReadLine();
            var funcionario = funcionarios.Find(f => f.Login == login);
            ValidarFuncionario(funcionario);
            return funcionario;
        }

        private static void ValidarFuncionario(Funcionario? funcionario)
        {
            if (funcionario != null)
            {
                funcionario.Greet();
            }
            else
            {
                Console.WriteLine("Não há funcionário com esse login. Tente novamente.");
            }
        }
    }
}
