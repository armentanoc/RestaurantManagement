
using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos.Enum;
using RestaurantManagement.Core.Servico;
using System.Linq;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Gerente : Funcionario, IFuncionario
    {
        public Gerente(string Nome, string Login, decimal Salario) : base(Nome, Login, Salario) { }
        public override void Greet()
        {
            Console.Clear();
            Console.WriteLine(Titulo.OlaGerente());
            MenuOpcoesGerente();
        }

        private void MenuOpcoesGerente()
        {
            string[] menuGerente = { "Fechar Conta", "Processar Pagamento", "Sair" };
            Menu opcoes = new Menu(menuGerente);

            while (true)
            {
                Console.Clear();
                int selecaoGerente = opcoes.ExibirMenu(Titulo.OlaGerente());
                if (!AnalisarMenuOpcoesGerente(selecaoGerente))
                {
                    break;
                }
            }
        }
        private bool AnalisarMenuOpcoesGerente(int selecaoGerente)
        {
            Pedido pedido;
            switch (selecaoGerente)
            {
                case 0:
                    pedido = EscolherPedidoParaFecharConta();
                    if(pedido != null) {
                        pedido.FecharConta();
                    }
                    Menu.AguardarEntrada();
                    return true;
                case 1:
                    pedido = EscolherPedidoParaProcessarPagamento();
                    if (pedido != null)
                    {
                        pedido.ProcessarPagamento();
                    }
                    Menu.AguardarEntrada();
                    return true;
                case 2:
                    Console.WriteLine("Escolheu sair.");
                    return false;
                default:
                    return true;
            }
        }
        private Pedido EscolherPedidoParaProcessarPagamento()
        {
            var pedidos = PedidoRepositorio.Pedidos().Where(pedido => pedido._Pagamento != null && pedido._Pagamento.FoiPago == false).ToList();
            return AnalisarPedido(pedidos);
        }
        private Pedido EscolherPedidoParaFecharConta()
        {
            var pedidos = PedidoRepositorio.Pedidos().Where(pedido => pedido._Pagamento == null).ToList();
            return AnalisarPedido(pedidos);
        }
        private Pedido AnalisarPedido(List<Pedido> pedidos)
        {
            if (pedidos.Any())
            {
                int totalPedidos = pedidos.Count;
                string[] menuMesas = new string[totalPedidos + 1];
                ExibirMesas(menuMesas, totalPedidos, pedidos);
                return ExibirMenuMesas(menuMesas, totalPedidos, pedidos);
            }
            else
            {
                Console.WriteLine("Não há mesas nessa situação...");
                return null;
            }
        }
        private Pedido ExibirMenuMesas(string[] menuMesas, int totalPedidos, List<Pedido> pedidos)
        {
            Menu opcoes = new Menu(menuMesas);
            menuMesas[totalPedidos] = "Voltar";

            while (true)
            {
                Console.Clear();
                int selecaoGerente = opcoes.ExibirMenu(Titulo.OlaGerente());

                if (selecaoGerente == totalPedidos)
                {
                    Console.WriteLine("Retornando ao menu anterior...");
                    return null;
                }
                else
                {
                    return pedidos[selecaoGerente];
                }
            }
        }
        private void ExibirMesas(string[] menuMesas, int totalPedidos, List<Pedido> pedidos)
        {
            Console.WriteLine("Pedidos disponíveis:");
            for (int i = 0; i < totalPedidos; i++)
            {
                menuMesas[i] = $"Pedido da Mesa {pedidos[i].GetMesa().Numero}";
            }
        }
    }
}
