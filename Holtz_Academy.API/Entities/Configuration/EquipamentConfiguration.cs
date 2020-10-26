using Holtz_Academy.API.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities.Configuration
{
    public class EquipamentConfiguration : EntityConfiguration<Equipament>, IEntityTypeConfiguration<Equipament>
    {
        public void Configure(EntityTypeBuilder<Equipament> builder)
        {

            DefaultConfigs(builder, "Equipament");
            builder.HasKey(key => key.EquipamentCode);
            builder.Property(x => x.EquipamentCode)
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedOnAdd();
            //.ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.EquipamentStatus)
                .HasColumnType(Tipo.STATUS)
                .ValueGeneratedNever();

            builder.Property(x => x.EquipamentName)
                .HasColumnType(Tipo.VARCHAR075)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.BranchBranchCode)
                .HasColumnName("BranchCode")
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedNever(); //Remove Identity
        }
    }
}
