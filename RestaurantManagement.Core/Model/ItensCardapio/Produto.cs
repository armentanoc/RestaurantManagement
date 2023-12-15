﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Model.ItensCardapio
{
    internal abstract class Produto
    {
        private decimal _id;
        public decimal Id { get { return _id; } private set { } }
        public string Nome { get; private set; }
        public string Descricao { get; private set;}
        public double Preco { get; private set;}

        protected Produto(string nome, string descricao, double preco)
        {
            this.Id = GerarId();
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public void AtualizarDescricao(string novaDescricao)
        {
            this.Descricao = novaDescricao;
        }

        public void AtualizarPreco(double novoPreco)
        {
            this.Preco = novoPreco;
        }

        private decimal GerarId()
        {
            string agora = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") ;
           
            return decimal.Parse(agora);
        }

        public abstract override string ToString();
    }
}