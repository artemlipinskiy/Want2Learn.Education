﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Want2Learn.EF;

namespace Want2Learn.EF.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20231016154740_addOwnerTable")]
    partial class addOwnerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlatOwner", b =>
                {
                    b.Property<int>("FlatsFlatId")
                        .HasColumnType("int");

                    b.Property<int>("OwnersOwnerId")
                        .HasColumnType("int");

                    b.HasKey("FlatsFlatId", "OwnersOwnerId");

                    b.HasIndex("OwnersOwnerId");

                    b.ToTable("FlatOwner");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Building", b =>
                {
                    b.Property<int>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("BuildingId");

                    b.HasIndex("StreetId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Flat", b =>
                {
                    b.Property<int>("FlatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("FlatId");

                    b.HasIndex("BuildingId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreetId");

                    b.HasIndex("CityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("FlatOwner", b =>
                {
                    b.HasOne("Want2Learn.EF.Entities.Flat", null)
                        .WithMany()
                        .HasForeignKey("FlatsFlatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Want2Learn.EF.Entities.Owner", null)
                        .WithMany()
                        .HasForeignKey("OwnersOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Building", b =>
                {
                    b.HasOne("Want2Learn.EF.Entities.Street", "Street")
                        .WithMany("Buildings")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Street");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Flat", b =>
                {
                    b.HasOne("Want2Learn.EF.Entities.Building", "Building")
                        .WithMany("Flats")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Street", b =>
                {
                    b.HasOne("Want2Learn.EF.Entities.City", "City")
                        .WithMany("Streets")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Building", b =>
                {
                    b.Navigation("Flats");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.City", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("Want2Learn.EF.Entities.Street", b =>
                {
                    b.Navigation("Buildings");
                });
#pragma warning restore 612, 618
        }
    }
}
