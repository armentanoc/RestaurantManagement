using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Garcom : Funcionario
    {
        public Garcom(string Nome, decimal Salario) : base(Nome, Salario) { }
    }
}
