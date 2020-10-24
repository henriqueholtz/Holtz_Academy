using Holtz_Academy.API.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities.Configuration
{
    public class StudentConfiguration : EntityConfiguration<Student>, IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            DefaultConfigs(builder, "Student");

            builder.HasKey(key => key.StudentCode);
            builder.Property(x => x.StudentCode)
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedOnAdd();
            //.ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentaReason)
                .HasColumnType(Tipo.VARCHAR100)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentCityName)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentNeighborhood)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentStreet)
                .HasColumnType(Tipo.VARCHAR050)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.TeatcherCode)
                .HasColumnType(Tipo.CODE)
                .ValueGeneratedNever(); //Remove Identity

            builder.Property(x => x.StudentStatus)
                .HasColumnType(Tipo.STATUS)
                .ValueGeneratedNever();
        }
    }
}
