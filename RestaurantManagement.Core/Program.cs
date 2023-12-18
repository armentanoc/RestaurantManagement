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

            try
            {
                while (true)
                {
                    int selecaoUsuario = opcoes.ExibirMenu(Titulo.Principal());
                    AnalisarEscolhasUsuario(selecaoUsuario);
                    Menu.AguardarEntrada();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void AnalisarEscolhasUsuario(int selecaoUsuario)
        {
            switch (selecaoUsuario)
            {
                case 0:
                    Funcionario funcionario = Autenticacao.RealizarAutenticacao(FuncionarioRepositorio.Funcionarios());
                    break;
                case 1:
                    CardapioRepositorio.ExibirPratos();
                    CardapioRepositorio.ExibirBebidas();
                    break;
                case 2:
                    FuncionarioRepositorio.ExibirFuncionarios();
                    break;
                case 3:
                    MesaRepositorio.ExibirMesas();
                    break;
                case 4:
                    PedidoRepositorio.ExibirPedidos();
                    break;
                case 5:
                    PagamentoRepositorio.ExibirPagamentos();
                    break;
                case 6:
                    Console.WriteLine("Sair");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
