using Holtz_Academy.API.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities.Configuration
{
    public class TeatcherConfiguration : EntityConfiguration<Teatcher>, IEntityTypeConfiguration<Teatcher>
    {
        public void Configure(EntityTypeBuilder<Teatcher> builder)
        {

            DefaultConfigs(builder, "Teatcher");
            builder.HasKey(key => key.TeatcherCode);
            builder.Property(x => x.TeatcherCode)
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedOnAdd();
            //.ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.TeatcherStatus)
                .HasColumnType(Tipo.STATUS)
                .ValueGeneratedNever();

            builder.Property(x => x.TeatcherReason)
                .HasColumnType(Tipo.VARCHAR075)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.TeatcherNeighborhood)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.TeatcherCityName)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.TeatcherStreet)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity
        }
    }
}
