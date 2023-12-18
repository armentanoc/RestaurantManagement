using System;
using System.Collections.Generic;
using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Modelos.ItensCardapio;

namespace RestaurantManagement.Core.Servico
{
    internal class CardapioRepositorio
    {
        public static List<Produto> Bebidas()
        {
            return new List<Produto>()
            {
                new Bebida("Suco de Uva", 500, false, "Suco da Fruta", 10),
                new Bebida("Suco de Laranja", 500, false, "Suco da Fruta", 12),
                new Bebida("Vodka", 1000, true, "Bebida proibida para menores", 25),
                new Bebida("Refrigerante", 600, false, "Refrigerante da marca 'Marca'", 15),
                new Bebida("Água", 800, false, "Água da bica", 4),
            };
        }

        public static List<Produto> Pratos()
        {
            return new List<Produto>
            {
                new Prato("Hamburguer", false, "X-Burguer", 700, CategoriaPrato.Principal, 25),
                new Prato("Arroz com feijão (apenas)", false, "Almoço tradicional", 700, CategoriaPrato.Principal, 25),
                new Prato("Batatas Fritas", false, "Muita batata inglesa", 2000, CategoriaPrato.Entrada, 10),
                new Prato("Salada", true, "Prato principal", 500, CategoriaPrato.Principal, 45),
                new Prato("Pão de alho", true, "Prato alternativo", 900, CategoriaPrato.Entrada, 3),
                new Prato("Sorvete", false, "Sorvete de pote", 400, CategoriaPrato.Sobremesa, 13),
                new Prato("Pudim", false, "Pudim de leite condensado", 400, CategoriaPrato.Sobremesa, 12),
            };
        }

        public static void ExibirBebidas()
        {
            Console.WriteLine("\nBebidas no Cardápio:");
            foreach (var bebida in Bebidas())
            {
                Console.WriteLine("\n" + bebida.ToString());
            }
        }

        public static void ExibirPratos()
        {
            Console.WriteLine("Pratos no Cardápio:");
            foreach (var prato in Pratos())
            {
                Console.WriteLine("\n" + prato.ToString());
            }
        }
    }
}
