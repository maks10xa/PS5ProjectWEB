using Microsoft.EntityFrameworkCore;

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
        public virtual DbSet<ShowAdminsPhoneNumber> ShowAdminsPhoneNumbers { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserHistory> UserHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
                entity.Property(e => e.CostOfPeriod).HasColumnType("money");

                entity.Property(e => e.TimePeriod)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasIndex(e => e.GameName, "idx_games");

                entity.Property(e => e.GameGenre).HasMaxLength(64);

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");
            });

            modelBuilder.Entity<ShowAdminsPhoneNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ShowAdminsPhoneNumber");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(13)
                    .IsFixedLength(true);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.Property(e => e.TimeOfTimeZone)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeZoneName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.IsAdminPs).HasColumnName("AdminPS");

                entity.Property(e => e.FavoriteGame).HasMaxLength(64);

                entity.Property(e => e.Pass).HasMaxLength(18);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(64);

                entity.HasOne(d => d.ContactsNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ContactsId)
                    .HasConstraintName("FK__Users__ContactsI__34C8D9D1");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Users__GameId__300424B4");
            });

            modelBuilder.Entity<UserHistory>(entity =>
            {
                entity.ToTable("UserHistory");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
