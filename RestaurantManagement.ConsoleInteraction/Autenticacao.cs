using System;
using System.Collections.Generic;
using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.ConsoleInteraction
{
    internal class Autenticacao
    {
        public static List<Funcionario> Funcionarios { get; private set; }

        static Autenticacao()
        {
            Funcionarios = new List<Funcionario>
            {
                new Gerente("Maria da Silva", "maria", 5000),
                new Garcom("Joao Santos", "joao", 2000)
            };
        }

        public static void RealizarAutenticacao()
        {
            Console.Write("Digite o login: ");
            string login = Console.ReadLine();

            var funcionario = Funcionarios.Find(f => f.Login == login);

            if (funcionario is Gerente)
            {
                Console.WriteLine("Gerente autenticado");
            }
            else if (funcionario is Garcom)
            {
                Console.WriteLine("Garçom autenticado");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado ou não reconhecido.");
            }
        }
    }
}
