using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core
{
    internal class Lista
    {
        internal static List<Funcionario> Funcionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;

            funcionario = new Funcionario("Carol", "carol", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Funcionario("Paula", "paula", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Funcionario("Vitória", "vitoria", 7000);
            funcionarios.Add(funcionario);

            return funcionarios;
        }
    }
}