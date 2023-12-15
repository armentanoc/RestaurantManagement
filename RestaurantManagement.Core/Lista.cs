using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core
{
    internal class Lista
    {
        internal static List<Funcionario> Funcionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;

            funcionario = new Funcionario("Carol", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Funcionario("Paula", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Funcionario("Vitória", 7000);
            funcionarios.Add(funcionario);

            return funcionarios;
        }
    }
}