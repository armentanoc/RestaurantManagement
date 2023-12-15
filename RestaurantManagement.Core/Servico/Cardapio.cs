using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Modelos.ItensCardapio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Servico
{
    public static class Cardapio
    {
        private static List<Produto> Bebidas = new List<Produto>
        {
            new Bebida("Suco de Uva", 500, false, "Suco da Fruta", 10.0),
            new Bebida("Suco de Laranja", 500, false, "Suco da Fruta", 12.0),
            new Bebida("Vodka", 1000, true, "Bebida proibida para menores", 25.0),
            new Bebida("Refrigerante", 600, false, "Refrigerante da marca 'Marca'", 15.0),
            new Bebida("Água", 800, false, "Água da bica", 4.0),
        };

        private static List<Produto> pratos = new List<Produto>
        {
            new Prato("Hamburguer", false, "X-Burguer",700, CategoriaPrato.Principal,  25.0),
            new Prato("Arroz com feijão (apenas)", false, "Almoço tradicional",700, CategoriaPrato.Principal, 25.0),
            new Prato("Batatas Fritas", false, "Muita batata inglesa",2000, CategoriaPrato.Entrada, 10.0),
            new Prato("Salada", true, "Prato principal", 500, CategoriaPrato.Principal, 45.0),
            new Prato("Pão de alho", true, "Prato alternativo", 900, CategoriaPrato.Entrada, 3.0),
            new Prato("Sorvete", false, "Sorvete de pote", 400, CategoriaPrato.Sobremesa, 13.0),
            new Prato("Pudim", false, "Pudim de leite condensado", 400, CategoriaPrato.Sobremesa, 12.0),
        };

        public static void ExibirBebidas()
        {
            Console.WriteLine("Bebidas no Cardápio:");
            foreach (var bebida in Bebidas)
            {
                Console.WriteLine(bebida.ToString());
            }
        }

        public static void ExibirPratos()
        {
            Console.WriteLine("Pratos no Cardápio:");
            foreach (var prato in pratos)
            {
                Console.WriteLine(prato.ToString());
            }
        }

    }
}
