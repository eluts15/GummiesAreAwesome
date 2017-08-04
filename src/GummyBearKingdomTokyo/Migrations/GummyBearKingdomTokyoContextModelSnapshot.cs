using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummyBearKingdomTokyo.Models;

namespace GummyBearKingdomTokyo.Migrations
{
    [DbContext(typeof(GummyBearKingdomTokyoContext))]
    partial class GummyBearKingdomTokyoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummyBearKingdomTokyo.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("CountryOfOrigin");

                    b.Property<int>("InStock");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });
        }
    }
}
