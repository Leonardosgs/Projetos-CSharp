namespace Listando.Models
{
    public class ListaModel
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public Decimal Precototal { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public UsuarioModel? Usuario { get; set; }
        public ICollection<ItemModel>? ListaItens { get; set; } = new List<ItemModel>();
        public MercadoModel Mercado { get; set; } 

        public ListaModel()
        {
        }

        public void AdicionarItem(ItemModel item)
        {
            item.ValorMultiQuatidade = Decimal.Multiply(new Decimal(item.Quantidade), item.PrecoUnidade);
            Precototal = Decimal.Add(Precototal, item.ValorMultiQuatidade);
            ListaItens.Add(item);
            item.Lista = this;
        }

        public override bool Equals(object? obj)
        {
            return obj is ListaModel lista &&
                   Nome == lista.Nome &&
                   Precototal == lista.Precototal &&
                   EqualityComparer<UsuarioModel?>.Default.Equals(Usuario, lista.Usuario) &&
                   EqualityComparer<MercadoModel?>.Default.Equals(Mercado, lista.Mercado);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Precototal, Usuario, Mercado);
        }
    }
}
