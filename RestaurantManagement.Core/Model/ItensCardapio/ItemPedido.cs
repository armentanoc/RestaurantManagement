using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.ItensCardapio
{
    internal class ItemPedido
    {
        public Produto produto { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorTotal { get; private set; }
        public ItemPedido(Produto produto, int quantidade) { this.produto = produto; this.Quantidade = quantidade; this.CalcularValorTotal(); }

        private void CalcularValorTotal()
        {
            this.ValorTotal = produto.Preco * Quantidade;
        }

        public Produto getProduto() {  return produto; }
        public int getQuantidade() {  return Quantidade; }
        public double getValorTotal() {  return ValorTotal; }

        public void AdicionarMais(int quantidadeAMais)
        {
            this.Quantidade += quantidadeAMais;
            this.CalcularValorTotal();
        }
    }
}
