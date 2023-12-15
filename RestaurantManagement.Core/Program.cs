using RestaurantManagement.ConsoleInteraction;

namespace RestaurantManagement.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuPrincipal = { "Um", "Dois", "Três", "Sair" };
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
                    Console.WriteLine("Um");
                    AguardarTresSegundos();
                    break;
                case 1:
                    Console.WriteLine("Dois");
                    AguardarTresSegundos();
                    break;
                case 2:
                    Console.WriteLine("Três");
                    AguardarTresSegundos();
                    break;
                case 3:
                    Console.WriteLine("Programa encerrado");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    AguardarTresSegundos();
                    break;
            }
        }

        private static void AguardarTresSegundos()
        {
            Console.CursorVisible = false;
            Thread.Sleep(3000);
        }
    }
}
