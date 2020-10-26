using Holtz_Academy.API.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities.Configuration
{
    public class BranchConfiguration : EntityConfiguration<Branch>, IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {

            DefaultConfigs(builder, "Branch");
            builder.HasKey(key => key.BranchCode);
            builder.Property(x => x.BranchCode)
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedOnAdd();
            //.ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.BranchStatus)
                .HasColumnType(Tipo.STATUS)
                .ValueGeneratedNever();

            builder.Property(x => x.BranchReason)
                .HasColumnType(Tipo.VARCHAR075)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.BranchNeighborhood)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.BranchCityName)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.BranchStreet)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity


            /*builder.Property(x => x.TeatcherTeatcherCode)
                .HasColumnName("TeatcherCode")
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentStudentCode)
                .HasColumnName("StudentCode")
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedNever(); //Remove Identity*/
        }
    }
}
