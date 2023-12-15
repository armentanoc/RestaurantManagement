using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.ItensCardapio
{
    internal class Bebida : Produto
    {
        public Bebida(string nome, double volume, bool alcoolico, string descricao, double preco) : base(nome, descricao, preco)
        {
            this.Volume = volume;
            this.Alcoolico = alcoolico;
        }

        public double Volume { get; set; }
        public bool Alcoolico { get; set; }


        public override string ToString()
        {
            string ehalcoolico = Alcoolico ? ("Bebida alcoólica") : ("Bebida não alcoólica");
            return $"ID {Id} | {Nome} | R${Preco}\n->{ehalcoolico} | {Volume} ml";
        }
    }
}
