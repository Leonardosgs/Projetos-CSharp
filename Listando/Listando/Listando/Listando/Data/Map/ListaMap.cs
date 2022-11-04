using Listando.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Listando.Data.Map
{
    public class ListaMap : IEntityTypeConfiguration<ListaModel>
    {
        public void Configure(EntityTypeBuilder<ListaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Precototal);
            builder.Property(x => x.DataCriacao);
        }
    }
}
