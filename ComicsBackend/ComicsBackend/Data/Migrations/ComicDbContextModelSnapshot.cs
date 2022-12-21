﻿// <auto-generated />
using ComicsBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComicsBackend.Data.Migrations
{
    [DbContext(typeof(ComicDbContext))]
    partial class ComicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComicsBackend.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Steve Ditko"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jack Kirby"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bob Kane"
                        });
                });

            modelBuilder.Entity("ComicsBackend.Models.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("CoverArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("CoverArtistId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("WriterId");

                    b.ToTable("Comics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 2,
                            CoverArtistId = 2,
                            Description = "Bla Bla Bla",
                            Image = "Cover.jpg",
                            Popularity = 0,
                            PublisherId = 1,
                            Title = "Spider-man #1",
                            WriterId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 3,
                            CoverArtistId = 3,
                            Description = "Bla Bla Bla",
                            Image = "Cover.jpg",
                            Popularity = 0,
                            PublisherId = 2,
                            Title = "Santman #1",
                            WriterId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            CoverArtistId = 3,
                            Description = "Bla Bla Bla",
                            Image = "Cover.jpg",
                            Popularity = 0,
                            PublisherId = 3,
                            Title = "Walking Dead #1",
                            WriterId = 3
                        });
                });

            modelBuilder.Entity("ComicsBackend.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("ComicsBackend.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ComicId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.ToTable("libraries");
                });

            modelBuilder.Entity("ComicsBackend.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marvel Comics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "DC Comics"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dark Horse Comics"
                        });
                });

            modelBuilder.Entity("ComicsBackend.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ComicsBackend.Models.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Writers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Stan Lee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Neil Gaiman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dan Slott"
                        });
                });

            modelBuilder.Entity("HeroTeam", b =>
                {
                    b.Property<int>("heroesId")
                        .HasColumnType("int");

                    b.Property<int>("teamsId")
                        .HasColumnType("int");

                    b.HasKey("heroesId", "teamsId");

                    b.HasIndex("teamsId");

                    b.ToTable("HeroTeam");
                });

            modelBuilder.Entity("ComicsBackend.Models.Comic", b =>
                {
                    b.HasOne("ComicsBackend.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ComicsBackend.Models.Artist", "CoverArtist")
                        .WithMany()
                        .HasForeignKey("CoverArtistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ComicsBackend.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComicsBackend.Models.Writer", "Writer")
                        .WithMany()
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("CoverArtist");

                    b.Navigation("Publisher");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("ComicsBackend.Models.Library", b =>
                {
                    b.HasOne("ComicsBackend.Models.Comic", "Comic")
                        .WithMany()
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");
                });

            modelBuilder.Entity("HeroTeam", b =>
                {
                    b.HasOne("ComicsBackend.Models.Hero", null)
                        .WithMany()
                        .HasForeignKey("heroesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComicsBackend.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("teamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
