
namespace RestaurantManagement.Core.Modelos.ItensCardapio
{
    internal class Bebida : Produto
    {
        public Bebida(string nome, double volume, bool alcoolico, string descricao, double preco) : base(nome, descricao, preco)
        {
            Volume = volume;
            Alcoolico = alcoolico;
        }

        public double Volume { get; set; }
        public bool Alcoolico { get; set; }


        public override string ToString()
        {
            string ehAlcoolico = Alcoolico ? "Bebida alcoólica" : "Bebida não alcoólica";
            return $"ID {Id} | {Nome} | R${Preco}\n-> {ehAlcoolico} | {Volume} ml";
        }
    }
}
