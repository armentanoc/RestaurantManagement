using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos;
using RestaurantManagement.Core.Modelos.Pessoas;
using RestaurantManagement.Core.Servico;

namespace RestaurantManagement.Core
{
    internal class Program
    {
        static List<Funcionario> funcionarios = Lista.Funcionarios();
        static List<Pedido> pedidos = new List<Pedido>();
        static void Main(string[] args)
        {
            string[] menuPrincipal = { "Exibir Cardápio", "Exibir Funcionários", "Realizar Autenticação", "Sair"};

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
                    Cardapio.ExibirPratos();
                    Cardapio.ExibirBebidas();
                    AguardarEntrada();
                    break;
                case 1:
                    Console.WriteLine("Funcionários");
                    ImprimirFuncionarios();
                    AguardarEntrada();
                    break;
                case 2:
                    Funcionario funcionario = Autenticacao.RealizarAutenticacao(funcionarios);
                    //Pedido pedido = NovoMetodoParaCriarPedido(funcionario);
                    //pedidos.Add(pedido);
                    break;
                case 3:
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
                Console.WriteLine($"{funcionario.Nome} - {funcionario.Salario} - {funcionario.GetType().ToString().Remove(0, 42)}");
            }
        }

        private static void AguardarTresSegundos()
        {
            Console.CursorVisible = false;
            Thread.Sleep(3000);
        }

        private static void AguardarEntrada()
        {
            Console.WriteLine("\nDigite qualquer tecla para continuar...\n");
            Console.ReadKey();
        }
    }
}
