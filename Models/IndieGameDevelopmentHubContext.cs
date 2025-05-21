using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IndieGameDevelopmentHubApp.Models;

public partial class IndieGameDevelopmentHubContext : DbContext
{
    public IndieGameDevelopmentHubContext()
    {
    }

    public IndieGameDevelopmentHubContext(DbContextOptions<IndieGameDevelopmentHubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<BugReport> BugReports { get; set; }

    public virtual DbSet<Developer> Developers { get; set; }

    public virtual DbSet<DeveloperFinance> DeveloperFinances { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameGenre> GameGenres { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Tester> Testers { get; set; }

    public virtual DbSet<TestersAccess> TestersAccesses { get; set; }

    public virtual DbSet<WorksOn> WorksOns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=IndieGameDevelopmentHub;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSETS__43492372E0BF6965");

            entity.ToTable("ASSETS");

            entity.HasIndex(e => e.AssetName, "AssetNameIndex");

            entity.Property(e => e.AssetId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("AssetID");
            entity.Property(e => e.AssetName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.AssetType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");

            entity.HasOne(d => d.Dev).WithMany(p => p.Assets)
                .HasForeignKey(d => d.DevId)
                .HasConstraintName("FK__ASSETS__DevID__0C85DE4D");

            entity.HasOne(d => d.Game).WithMany(p => p.Assets)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__ASSETS__GameID__0B91BA14");
        });

        modelBuilder.Entity<BugReport>(entity =>
        {
            entity.HasKey(e => new { e.ReportId, e.GameId }).HasName("PK__BUG_REPO__1716C1983F30A0C4");

            entity.ToTable("BUG_REPORTS");

            entity.Property(e => e.ReportId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("ReportID");
            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.Report)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TesterId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("TesterID");

            entity.HasOne(d => d.Game).WithMany(p => p.BugReports)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BUG_REPOR__GameI__18EBB532");

            entity.HasOne(d => d.Tester).WithMany(p => p.BugReports)
                .HasForeignKey(d => d.TesterId)
                .HasConstraintName("FK__BUG_REPOR__Teste__19DFD96B");
        });

        modelBuilder.Entity<Developer>(entity =>
        {
            entity.HasKey(e => e.DevId).HasName("PK__DEVELOPE__D9159EEECE565467");

            entity.ToTable("DEVELOPERS");

            entity.HasIndex(e => e.Email, "DevEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__DEVELOPE__A9D1053465250BDF").IsUnique();

            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.Email)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeveloperFinance>(entity =>
        {
            entity.HasKey(e => e.DevId).HasName("PK__DEVELOPE__D9159EEEDED83B4E");

            entity.ToTable("DEVELOPER_FINANCES");

            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.Income).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RaiseRate).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Dev).WithOne(p => p.DeveloperFinance)
                .HasForeignKey<DeveloperFinance>(d => d.DevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DEVELOPER__DevID__778AC167");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__EVENTS__2DC7BD69DDA74B29");

            entity.ToTable("EVENTS");

            entity.Property(e => e.EventId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("eventID");
            entity.Property(e => e.Description)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.EventEndDate).HasColumnType("datetime");
            entity.Property(e => e.EventStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameId).HasName("PK__GAMES__2AB897DD6CA96BC5");

            entity.ToTable("GAMES");

            entity.HasIndex(e => e.Title, "TitleIndex");

            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.GameRating).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GameGenre>(entity =>
        {
            entity.HasKey(e => new { e.GameId, e.Genre }).HasName("PK__GAME_GEN__15AC87127D3CA799");

            entity.ToTable("GAME_GENRES");

            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.Genre)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Game).WithMany(p => p.GameGenres)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GAME_GENR__GameI__01142BA1");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__PLAYERS__4A4E74A8A3330E09");

            entity.ToTable("PLAYERS");

            entity.HasIndex(e => e.Email, "PlayerEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__PLAYERS__A9D105346B40EEBD").IsUnique();

            entity.Property(e => e.PlayerId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("PlayerID");
            entity.Property(e => e.Email)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.PlayerName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__REVIEWS__74BC79AE22BA5432");

            entity.ToTable("REVIEWS");

            entity.Property(e => e.ReviewId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("ReviewID");
            entity.Property(e => e.ByPlayerId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("ByPlayerID");
            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.LastName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Review1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Review");
            entity.Property(e => e.ReviewDate).HasColumnType("datetime");

            entity.HasOne(d => d.ByPlayer).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ByPlayerId)
                .HasConstraintName("FK__REVIEWS__ByPlaye__07C12930");

            entity.HasOne(d => d.Game).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__REVIEWS__GameID__08B54D69");
        });

        modelBuilder.Entity<Tester>(entity =>
        {
            entity.HasKey(e => e.TesterId).HasName("PK__TESTERS__61EB7DFB8849BEC2");

            entity.ToTable("TESTERS");

            entity.HasIndex(e => e.Email, "TesterEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__TESTERS__A9D105344D7B9F18").IsUnique();

            entity.Property(e => e.TesterId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("TesterID");
            entity.Property(e => e.Email)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.IsLicensed).HasDefaultValue(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestersAccess>(entity =>
        {
            entity.HasKey(e => new { e.GameId, e.TesterId }).HasName("PK__TESTERS___8CA620020151BB14");

            entity.ToTable("TESTERS_ACCESS");

            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.TesterId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("TesterID");

            entity.HasOne(d => d.Game).WithMany(p => p.TestersAccesses)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TESTERS_A__GameI__14270015");

            entity.HasOne(d => d.Tester).WithMany(p => p.TestersAccesses)
                .HasForeignKey(d => d.TesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TESTERS_A__Teste__1332DBDC");
        });

        modelBuilder.Entity<WorksOn>(entity =>
        {
            entity.HasKey(e => new { e.DevId, e.GameId }).HasName("PK__WORKS_ON__1BBE1793078C0EC6");

            entity.ToTable("WORKS_ON");

            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("role");

            entity.HasOne(d => d.Dev).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.DevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__DevID__7D439ABD");

            entity.HasOne(d => d.Game).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__GameID__7E37BEF6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
