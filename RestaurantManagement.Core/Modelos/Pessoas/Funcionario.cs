
namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal abstract class Funcionario : IFuncionario 
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string login, decimal salario)
        {
            Nome = nome;
            Login = login;
            Salario = salario;
        }

        public abstract void Greet();
    }
}
