using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.ItensCardapio
{
    internal abstract class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }

        protected Produto(string nome, string descricao, double preco)
        {
            Id = GerarId();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public void AtualizarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;
        }

        public void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }

        private int GerarId()
        {
            return Math.Abs(DateTime.Now.GetHashCode());
        }

        public abstract override string ToString();
    }
}
