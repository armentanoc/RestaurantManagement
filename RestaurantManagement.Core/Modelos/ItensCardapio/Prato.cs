using RestaurantManagement.Core.Modelos.Enum;

namespace RestaurantManagement.Core.Modelos.ItensCardapio
{
    internal class Prato : Produto
    {
        public bool Vegetariano { get; private set; }
        public int Gramas { get; private set; }
        public CategoriaPrato Categoria { get; private set; }
        public Prato(string nome, bool vegetariano, string descricao, int gramas, CategoriaPrato categoria, decimal preco) : base(nome, descricao, preco)
        {
            Vegetariano = vegetariano;
            Gramas = gramas;
            Categoria = categoria;
        }
        public void AlterarQuantidadeGramas(int gramas) { 
            Gramas = gramas; 
        }

        public override string ToString()
        {
            string ehVegetariano = Vegetariano ? "Prato vegetariano" : "Prato de origem animal";
            return $"ID {Id} | {Nome} | {Gramas}g | R${Preco}\n-> {ehVegetariano} | {Categoria.ToString()}";
        }
    }
}
