using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Gerente : Funcionario
    {
        public Gerente(string Nome, decimal Salario) : base(Nome, Salario) { }
    }
}
