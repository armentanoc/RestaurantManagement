using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.ItensCardapio
{
    internal class ItemPedido
    {
        private Produto produto;
        private int quantidade;
        private double valorTotal;
        public ItemPedido(Produto produto, int quantidade) { this.produto = produto; this.quantidade = quantidade; this.CalcularValorTotal(); }

        private void CalcularValorTotal()
        {
            this.valorTotal = produto.Preco * quantidade;
        }

        public Produto getProduto() {  return produto; }
        public int getQuantidade() {  return quantidade; }
        public double getValorTotal() {  return valorTotal; }
    }
}
