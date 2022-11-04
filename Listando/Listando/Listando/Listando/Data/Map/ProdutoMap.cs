using Listando.Models;
using Listando.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listando.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(p => p.Id).HasName("produto_id");
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.UnidadeVolume)
                .HasConversion(p => p.ToString(), p => (UnidadeVolume)Enum.Parse(typeof(UnidadeVolume), p)).IsRequired();
            builder.Property(p => p.Volume).IsRequired();
        }
    }
}
