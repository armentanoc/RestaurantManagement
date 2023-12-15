
namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Gerente : Funcionario, IFuncionario
    {
        public Gerente(string Nome, string Login, decimal Salario) : base(Nome, Login, Salario) { }
        public override void Greet()
        {
            Console.WriteLine("Olá, gerente!");
        }
    }

}
