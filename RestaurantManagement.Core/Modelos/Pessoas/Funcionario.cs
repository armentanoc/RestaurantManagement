using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string Nome, string Login, decimal Salario)
        {
            Nome = Nome;
            Login = Login;
            Salario = Salario;
        }
    }
}
