using Listando.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Listando.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public UnidadeVolume UnidadeVolume { get; set; }
        public double Volume { get; set; }
        public MarcaModel Marca { get; set; }

        public ProdutoModel()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is ProdutoModel produto &&
                   Nome == produto.Nome &&
                   UnidadeVolume == produto.UnidadeVolume &&
                   Volume == produto.Volume;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, UnidadeVolume, Volume);
        }
    }
}
