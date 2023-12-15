using RestaurantManagement.Core.Model.Enum;
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
        public int Gramas {  get; set; }
        public CategoriaPrato Categoria { get; set; }

        public Prato(string nome, bool vegetariano, string descricao, int gramas, CategoriaPrato categoria, double preco) : base(nome, descricao, preco)
        {
            this.Vegetariano = vegetariano;
            this.Gramas = gramas;
            this.Categoria = categoria;
        }
        public override string ToString()
        {
            string ehvegetariano = Vegetariano ? ("Prato vegetariano") : ("Prato de origem animal");
            return $"ID {Id} | {Nome} | {Gramas} | R${Preco}\n->{ehvegetariano} | {Categoria.ToString()}";
        }

        public void AlterarQuantidadeGramas(int gramas) { this.Gramas = gramas; }
    }
}
