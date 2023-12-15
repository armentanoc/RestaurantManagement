
namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Garcom : Funcionario, IFuncionario
    {
        public Garcom(string Nome, string Login, decimal Salario) : base(Nome, Login, Salario) { }

        public override void Greet()
        {
            Console.WriteLine("Olá, garçom!");
        }
    }
}
