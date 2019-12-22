﻿// <auto-generated />
using System;
using AG.Users.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AG.Users.EFCore.Migrations
{
    [DbContext(typeof(UsersContext))]
    partial class UsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AG.Users.EFCore.Models.AUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<int>("UserType");
                });

            modelBuilder.Entity("AG.Users.EFCore.Models.Administrator", b =>
                {
                    b.HasBaseType("AG.Users.EFCore.Models.AUser");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("AG.Users.EFCore.Models.Operator", b =>
                {
                    b.HasBaseType("AG.Users.EFCore.Models.AUser");

                    b.Property<int?>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AdministratorId");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("AG.Users.EFCore.Models.Operator", b =>
                {
                    b.HasOne("AG.Users.EFCore.Models.Administrator", null)
                        .WithMany("Operators")
                        .HasForeignKey("AdministratorId");
                });
#pragma warning restore 612, 618
        }
    }
}
