using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummyBearKingdomTokyo.Models;

namespace GummyBearKingdomTokyo.Migrations
{
    [DbContext(typeof(GummyBearKingdomTokyoContext))]
    [Migration("20170809071455_PopulatedDbTest")]
    partial class PopulatedDbTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummyBearKingdomTokyo.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 60);

                    b.Property<int>("InStock");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 60);

                    b.HasKey("ID");

                    b.ToTable("Product");
                });
        }
    }
}
