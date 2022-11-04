namespace Listando.Models
{
    public class MercadoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public MercadoModel()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is MercadoModel mercado &&
                   Nome == mercado.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
