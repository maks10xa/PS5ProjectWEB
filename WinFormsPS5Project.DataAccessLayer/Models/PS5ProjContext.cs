using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class PS5ProjContext : DbContext
    {
        public PS5ProjContext()
        {
        }

        public PS5ProjContext(DbContextOptions<PS5ProjContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=PS5Proj;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(13)
                    .IsFixedLength(true);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Contacts__UserId__286302EC");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.Property(e => e.Cost1)
                    .HasColumnType("money")
                    .HasColumnName("Cost");

                entity.Property(e => e.TimePeriod)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameGenre).HasMaxLength(64);

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.AdminPs).HasColumnName("AdminPS");

                entity.Property(e => e.FavoriteGame).HasMaxLength(64);

                entity.Property(e => e.Pass).HasMaxLength(18);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(64);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Users__GameId__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
