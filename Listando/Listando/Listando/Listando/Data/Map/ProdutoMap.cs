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
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.UnidadeVolume)
                .HasConversion(p => p.ToString(), s => (UnidadeVolume)Enum.Parse(typeof(UnidadeVolume), s));
            builder.HasOne(m => m.Marca).WithMany();
        }
    }
}
