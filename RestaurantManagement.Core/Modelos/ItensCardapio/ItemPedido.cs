using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.ItensCardapio
{
    internal class ItemPedido
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorTotal { get; private set; }
        public ItemPedido(Produto produto, int quantidade) { 
            this.Produto = produto; 
            Quantidade = quantidade; 
            CalcularValorTotal(); 
        }
        public decimal CalcularValorTotal()
        {
            ValorTotal = this.Produto.Preco * Quantidade;
            return ValorTotal;
        }
        public void AdicionarMais(int quantidadeAMais)
        {
            Quantidade += quantidadeAMais;
            CalcularValorTotal();
        }
    }
}
