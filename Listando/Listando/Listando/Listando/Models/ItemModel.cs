namespace Listando.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Decimal PrecoUnidade { get; set; } = Decimal.Zero;
        public Decimal ValorMultiQuatidade { get; set; } = Decimal.Zero;
        public ListaModel Lista { get; set; }
        public ProdutoModel Produto { get; set; }

        public ItemModel()
        {
        }


    }
}
