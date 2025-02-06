﻿// <auto-generated />
using Assigment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assigment1.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assigment1.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "F",
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = "W",
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = "R",
                            CategoryName = "Friend"
                        });
                });

            modelBuilder.Entity("Assigment1.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = "R",
                            Email = "delores@hotmail.com",
                            FirstName = "Delores",
                            LastName = "Del Rio",
                            PhoneNumber = "555-987-6543"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = "W",
                            Email = "efren@aol.com",
                            FirstName = "Efren",
                            LastName = "Herrera",
                            PhoneNumber = "555-456-7890"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = "F",
                            Email = "MaryEllen@yahoo.com",
                            FirstName = "Mary Ellen",
                            LastName = "Walton",
                            PhoneNumber = "555-123-4567"
                        });
                });

            modelBuilder.Entity("Assigment1.Models.Contact", b =>
                {
                    b.HasOne("Assigment1.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
