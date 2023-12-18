using System;

namespace RestaurantManagement.Core.Modelos.Mesas
{
    internal class Mesa
    {
        public int Numero { get; }
        public int QuantidadeCadeiras { get; }
        public bool AreaExterna { get; private set; }
        public bool EstaOcupada { get; private set; }
        public Pedido? PedidoAtual { get; private set; }

        public Mesa(int numero, int quantidadeCadeiras, bool areaExterna)
        {
            Numero = numero;
            QuantidadeCadeiras = quantidadeCadeiras;
            AreaExterna = areaExterna;
            EstaOcupada = false;
        }

        public void LevarAreaExterna() => AreaExterna = true;

        public void AtualizarPedidoAtual(Pedido pedido) => PedidoAtual = pedido;

        public void IniciarNovoPedido()
        {
            if (!EstaOcupada)
            {
                throw new InvalidOperationException("A mesa não está ocupada para iniciar um novo pedido.");
            }

            PedidoAtual = new Pedido(this);
        }

        public void AlocarClientes() => EstaOcupada = true;

        public Pedido ObterPedidoAtual()
        {
            if (!EstaOcupada || PedidoAtual == null)
            {
                throw new InvalidOperationException("A mesa não está ocupada ou nenhum pedido foi iniciado.");
            }

            return PedidoAtual;
        }

        public void LiberarMesa()
        {
            EstaOcupada = false;
            PedidoAtual = null;
        }

        public override string ToString() =>
            $"Mesa nº: {Numero} - Cadeiras: {QuantidadeCadeiras} - Área Externa: {AreaExterna} - Está Ocupada: {EstaOcupada}";
    }
}