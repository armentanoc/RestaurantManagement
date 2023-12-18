using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos.Pessoas;
using RestaurantManagement.Core.Servico;

namespace RestaurantManagement.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuPrincipal = { "Área Logada", "Cardápio", "Funcionários", "Mesas", "Pedidos", "Pagamentos", "Sair"};

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
                    Funcionario funcionario = Autenticacao.RealizarAutenticacao(FuncionarioRepositorio.Funcionarios());
                    PedidoRepositorio.ExibirPedidos();
                    break;
                case 1:
                    CardapioRepositorio.ExibirPratos();
                    CardapioRepositorio.ExibirBebidas();
                    Menu.AguardarEntrada();
                    break;
                case 2:
                    FuncionarioRepositorio.ExibirFuncionarios();
                    Menu.AguardarEntrada();
                    break;
                case 3:
                    MesaRepositorio.ExibirMesas();
                    Menu.AguardarEntrada();
                    break;
                case 4:
                    PedidoRepositorio.ExibirPedidos();
                    Menu.AguardarEntrada();
                    break;
                case 5:
                    Console.WriteLine("TBD");
                    //PagamentoRepositorio.ExibirPagamentos(); ... e lógica subsequente
                    Menu.AguardarEntrada();
                    break;
                case 6:
                    Console.WriteLine("Sair");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Menu.AguardarEntrada();
                    break;
            }
        }
    }
}
