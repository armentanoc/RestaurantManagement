﻿using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos.Pessoas;

namespace RestaurantManagement.Core
{
    internal class Program
    {
        static List<Funcionario> funcionarios = Lista.Funcionarios();
        static void Main(string[] args)
        {
            string[] menuPrincipal = { "Exibir cardápio", "Exibir Funcionários", "Sair"};
            Menu opcoes = new Menu(menuPrincipal);

            while (true)
            {
                int selecaoUsuario = opcoes.ExibirMenu(Titulo.Principal());
                AnalisarEscolhasUsuario(selecaoUsuario);
            }
        }
        private static void AnalisarEscolhasUsuario(int selecaoUsuario)
        {
            switch (selecaoUsuario)
            {
                case 0:
                    Console.WriteLine("Cardápio");
                    //Exibir.Cardapio()
                    break;
                case 1:
                    Console.WriteLine("Funcionários");
                    ImprimirFuncionarios();
                    AguardarTresSegundos();
                    break;
                case 2:
                    Console.WriteLine("Sair");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    AguardarTresSegundos();
                    break;
            }
        }

        private static void ImprimirFuncionarios()
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Nome} - {funcionario.Salario}");
            }
        }

        private static void AguardarTresSegundos()
        {
            Console.CursorVisible = false;
            Thread.Sleep(3000);
        }
    }
}
