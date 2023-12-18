using System;
using System.Linq;
using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos.ItensCardapio;
using RestaurantManagement.Core.Modelos.Mesas;
using RestaurantManagement.Core.Servico;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal abstract class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string login, decimal salario)
        {
            Nome = nome;
            Login = login;
            Salario = salario;
        }

        public abstract void Greet();

        public virtual void AlocarClientesEmMesa()
        {
            var mesasDisponiveis = MesaRepositorio.MesasDisponiveis().ToArray();
            var menuMesasDisponiveis = mesasDisponiveis.Select(mesa => $"Mesa nº.: {mesa.Numero}").ToArray();

            if (mesasDisponiveis.Any())
            {
                Menu opcoes = new Menu(menuMesasDisponiveis);
                int mesaSelecionada = opcoes.ExibirMenu(Titulo.Principal());
                MesaRepositorio.AlocarClientesNaMesa(mesasDisponiveis[mesaSelecionada]);
            }
            else
            {
                Console.WriteLine("Não há mesas disponíveis.");
            }
        }

        public virtual void ReceberPedido()
        {
            var mesasComClientes = MesaRepositorio.MesasOcupadas().ToArray();
            var menuMesasComClientes = mesasComClientes.Select(mesa => $"Mesa nº.: {mesa.Numero}").ToArray();

            if (mesasComClientes.Any())
            {
                Menu opcoes = new Menu(menuMesasComClientes);
                int mesaSelecionada = opcoes.ExibirMenu(Titulo.Principal());

                Pedido pedido = mesasComClientes[mesaSelecionada].PedidoAtual;

                if (pedido == null)
                {
                    pedido = new Pedido(mesasComClientes[mesaSelecionada]);
                    mesasComClientes[mesaSelecionada].AtualizarPedidoAtual(pedido);
                }

                AdicionarPratoOuBebida(pedido);

                TentarAdicionarPedido(pedido);

                PedidoRepositorio.ExibirPedidos();
            }
            else
            {
                Console.WriteLine("Não há mesas ocupadas com clientes.");
            }
        }

        private void TentarAdicionarPedido(Pedido pedido)
        {
            if (!PedidoRepositorio.Pedidos().Contains(pedido))
                {
                    PedidoRepositorio.Pedidos().Add(pedido);
                }
        }

        public void AdicionarPratoOuBebida(Pedido pedido)
        {
            while (EscolherPratoOuBebida(pedido))
            {
                Menu.AguardarEntrada();
            }
        }

        public bool EscolherPratoOuBebida(Pedido pedido)
        {
            string[] menuPratoOuBebida = { "Adicionar Prato", "Adicionar Bebida", "Voltar" };
            Menu opcoes = new Menu(menuPratoOuBebida);
            int escolha = opcoes.ExibirMenu(Titulo.Principal());

            switch (escolha)
            {
                case 0:
                    AdicionarItemAoPedido(pedido, CardapioRepositorio.Pratos());
                    break;
                case 1:
                    AdicionarItemAoPedido(pedido, CardapioRepositorio.Bebidas());
                    break;
                case 2:
                    Console.WriteLine("Retornando ao menu anterior");
                    return false;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            return true;
        }

        public void AdicionarItemAoPedido(Pedido pedido, List<Produto> itensDisponiveis)
        {
            Console.WriteLine("Escolha o item:");

            for (int i = 0; i < itensDisponiveis.Count; i++)
            {
                Console.WriteLine($"{i}. {itensDisponiveis[i].Nome} - {itensDisponiveis[i].Preco:C}");
            }

            int escolhaItem = Menu.LerInteiro("Digite o número do item desejado:");

            if (escolhaItem >= 0 && escolhaItem < itensDisponiveis.Count)
            {
                int quantidade = Menu.LerInteiro("Digite a quantidade:");

                if (quantidade > 0)
                {
                    pedido.AdicionarItens(itensDisponiveis[escolhaItem], quantidade);
                    Console.WriteLine($"Item '{itensDisponiveis[escolhaItem].Nome}' adicionado ao pedido.");
                }
                else
                {
                    Console.WriteLine("Quantidade inválida. Item não adicionado ao pedido.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Item não adicionado ao pedido.");
            }
        }

        public override string ToString()
        {
            return $"{Nome} - {Salario} - {GetType().ToString().Remove(0, 42)}";
        }
    }
}
