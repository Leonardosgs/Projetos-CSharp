using Listando.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listando.Data.Map
{
    public class MarcaMap : IEntityTypeConfiguration<MarcaModel>
    {
        public void Configure(EntityTypeBuilder<MarcaModel> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Nome).HasMaxLength(255).IsRequired();
        }
    }
}
