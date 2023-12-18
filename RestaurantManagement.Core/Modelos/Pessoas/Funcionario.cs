using System;
using System.Globalization;
using RestaurantManagement.ConsoleInteraction;
using RestaurantManagement.Core.Modelos.ItensCardapio;
using RestaurantManagement.Core.Modelos.Mesas;
using RestaurantManagement.Core.Servico;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal abstract class Funcionario : IFuncionario
    {
        public string Nome { get; private set; }
        public string Login { get; private set; }
        public decimal Salario { get; private set; }

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
            var menuMesasDisponiveis = mesasDisponiveis.Select(mesa => $"Mesa nº.: {mesa.Numero}").Concat(new[] { "Voltar" }).ToArray();

            if (mesasDisponiveis.Any())
            {
                Menu opcoes = new Menu(menuMesasDisponiveis);
                int mesaSelecionada = opcoes.ExibirMenu(Titulo.Principal());

                if (mesaSelecionada == mesasDisponiveis.Length) // "Voltar" option
                {
                    Console.WriteLine("Retornando ao menu anterior...");
                }
                else
                {
                    Mesa mesa = mesasDisponiveis[mesaSelecionada];
                    MesaRepositorio.AlocarClientesNaMesa(mesa);
                    Console.WriteLine($"Clientes alocados na mesa {mesa.Numero}");
                }
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

                Pedido? pedido = mesasComClientes[mesaSelecionada].PedidoAtual;

                if (pedido == null)
                {
                    pedido = new Pedido(mesasComClientes[mesaSelecionada]);
                    mesasComClientes[mesaSelecionada].AtualizarPedidoAtual(pedido);
                }

                AdicionarPratoOuBebida(pedido);

                TentarAdicionarPedido(pedido);

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

            string[] menuItens = itensDisponiveis
                .Select((produto, index) => $"{produto.Nome} - {produto.Preco:C}")
                .Concat(new[] { "Voltar" }) // Add "Voltar" at the end
                .ToArray();

            Menu opcoesItens = new Menu(menuItens);
            int escolhaItem = opcoesItens.ExibirMenu("\nDigite o número do item desejado:");

            if (escolhaItem >= 0 && escolhaItem < itensDisponiveis.Count)
            {
                int quantidade = Menu.LerInteiro("Digite a quantidade:");

                if (quantidade > 0)
                {
                    pedido.AdicionarItens(itensDisponiveis[escolhaItem], quantidade);
                    Console.WriteLine($"\nItem '{itensDisponiveis[escolhaItem].Nome}' adicionado ao pedido da mesa {pedido.GetMesa().Numero}.");
                }
                else
                {
                    Console.WriteLine("\nQuantidade inválida. Item não adicionado ao pedido.");
                }
            }
            else if (escolhaItem == itensDisponiveis.Count) // "Voltar" 
            {
                Console.WriteLine("Retornando ao menu anterior...");
            }
            else
            {
                Console.WriteLine("Opção inválida. Item não adicionado ao pedido.");
            }
        }

        public override string ToString()
        {
            return $"{Nome} - {Salario.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} - {GetType().ToString().Remove(0, 42)}";
        }
    }
}
