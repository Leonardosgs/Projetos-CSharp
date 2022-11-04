namespace Listando.Models
{
    public class MarcaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public MarcaModel()
        {
        }

        public MarcaModel(string nome)
        {
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is MarcaModel marca &&
                   Nome == marca.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
