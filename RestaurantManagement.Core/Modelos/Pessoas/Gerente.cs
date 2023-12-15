using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
