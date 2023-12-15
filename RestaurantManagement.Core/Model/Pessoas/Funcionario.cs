using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.Pessoas
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string Nome, decimal Salario)
        {
            Nome = Nome;
            Salario = Salario;
        }
    }
}
