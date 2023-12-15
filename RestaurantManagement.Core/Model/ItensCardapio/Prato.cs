using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.ItensCardapio
{
    internal class Prato : Produto
    {
        public bool Vegetariano { get; set; }

        public Prato(string nome, bool vegetariano, string descricao, double preco) : base(nome, descricao, preco)
        {
            this.Vegetariano = vegetariano;
        }
        public override string ToString()
        {
            string ehvegetariano = Vegetariano ? ("Prato vegetariano") : ("Prato de origem animal");
            return $"ID {Id} | {Nome} | R${Preco}\n->{ehvegetariano}";
        }
    }
}
