using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; //EntityTypeBuilderusing System;

namespace Holtz_Academy.API.Entities
{
    public class EntityConfiguration<Tentity> where Tentity : class
    {
        //Define default settings
        public void DefaultConfigs(EntityTypeBuilder<Tentity> builder, string tableName)
        {
            builder.ToTable(tableName);

            //Others examples
            //builder.HasKey(x => x.UId);
            //builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
