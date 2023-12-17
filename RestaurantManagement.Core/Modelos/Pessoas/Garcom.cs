
using RestaurantManagement.ConsoleInteraction;

namespace RestaurantManagement.Core.Modelos.Pessoas
{
    internal class Garcom : Funcionario, IFuncionario
    {
        public Garcom(string Nome, string Login, decimal Salario) : base(Nome, Login, Salario) { }

        public override void Greet()
        {
            Console.WriteLine("\nOlá, garçom!");
            MenuOpcoesGarcom();
            }
        private void MenuOpcoesGarcom()
        {
            string[] menuGarcom = {"Alocar clientes em mesa", "Receber pedido", "Sair" };
            Menu opcoes = new Menu(menuGarcom);

            while (true)
            {
                Console.Clear();
                int selecaoGarcom = opcoes.ExibirMenu(Titulo.OlaGarcom());
                if (!AnalisarEscolhasGarcom(selecaoGarcom))
                {
                    break;
                }
            }
        }
        private bool AnalisarEscolhasGarcom(int selecaoGarcom)
        {
            switch (selecaoGarcom)
            {
                case 0:
                    AlocarClientesEmMesa();
                    Menu.AguardarEntrada();
                    return true;
                case 1: 
                    ReceberPedido();
                    Menu.AguardarEntrada();
                    return true;
                case 2:
                    Console.WriteLine("Escolheu sair.");
                    return false;
                default:
                    return true;
            }
        }
        public override void ReceberPedido()
        {
            base.ReceberPedido();
        }
        public override void AlocarClientesEmMesa()
        {
            base.AlocarClientesEmMesa();
        }
    }
}
