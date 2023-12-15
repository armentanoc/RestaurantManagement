using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core.Servico
{
    internal class Lista
    {
        internal static List<Funcionario> Funcionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;

            funcionario = new Garcom("Carol", "carol", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Garcom("Paula", "paula", 7000);
            funcionarios.Add(funcionario);

            funcionario = new Gerente("Vitória", "vitoria", 12000);
            funcionarios.Add(funcionario);

            return funcionarios;
        }
    }
}