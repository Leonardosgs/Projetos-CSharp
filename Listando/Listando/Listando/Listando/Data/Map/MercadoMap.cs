using Listando.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listando.Data.Map
{
    public class MercadoMap : IEntityTypeConfiguration<MercadoModel>
    {
        public void Configure(EntityTypeBuilder<MercadoModel> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Nome).HasMaxLength(255).IsRequired();
        }
    }
}
