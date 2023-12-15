using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public int Id { get; private set; }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
            Id = DateTime.Now.GetHashCode();
        }
    }
}
