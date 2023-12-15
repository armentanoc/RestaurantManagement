using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Garcom : Funcionario
    {
        public Garcom(string Nome, string Login, decimal Salario) : base(Nome, Login, Salario) { }
    }
}
