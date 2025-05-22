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
            entity.HasKey(e => e.AssetId).HasName("PK__ASSETS__43492372DFF6653D");

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
                .HasConstraintName("FK__ASSETS__DevID__3493CFA7");

            entity.HasOne(d => d.Game).WithMany(p => p.Assets)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__ASSETS__GameID__339FAB6E");
        });

        modelBuilder.Entity<BugReport>(entity =>
        {
            entity.HasKey(e => new { e.ReportId, e.GameId }).HasName("PK__BUG_REPO__1716C1989DE35B43");

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
                .HasConstraintName("FK__BUG_REPOR__GameI__40F9A68C");

            entity.HasOne(d => d.Tester).WithMany(p => p.BugReports)
                .HasForeignKey(d => d.TesterId)
                .HasConstraintName("FK__BUG_REPOR__Teste__41EDCAC5");
        });

        modelBuilder.Entity<Developer>(entity =>
        {
            entity.HasKey(e => e.DevId).HasName("PK__DEVELOPE__D9159EEE29B52ED8");

            entity.ToTable("DEVELOPERS");

            entity.HasIndex(e => e.Email, "DevEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__DEVELOPE__A9D1053451D40EE9").IsUnique();

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
            entity.HasKey(e => e.DevId).HasName("PK__DEVELOPE__D9159EEECFC3F838");

            entity.ToTable("DEVELOPER_FINANCES");

            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.Income).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RaiseRate).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Dev).WithOne(p => p.DeveloperFinance)
                .HasForeignKey<DeveloperFinance>(d => d.DevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DEVELOPER__DevID__1F98B2C1");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__EVENTS__7944C8702E4B27A5");

            entity.ToTable("EVENTS");

            entity.Property(e => e.EventId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("EventID");
            entity.Property(e => e.Description)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.EventEndDate).HasColumnType("datetime");
            entity.Property(e => e.EventStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameId).HasName("PK__GAMES__2AB897DD860D1CBF");

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
            entity.HasKey(e => new { e.GameId, e.Genre }).HasName("PK__GAME_GEN__15AC8712B5217C05");

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
                .HasConstraintName("FK__GAME_GENR__GameI__29221CFB");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__PLAYERS__4A4E74A826A79E2D");

            entity.ToTable("PLAYERS");

            entity.HasIndex(e => e.Email, "PlayerEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__PLAYERS__A9D10534E9022640").IsUnique();

            entity.Property(e => e.PlayerId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("PlayerID");
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

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__REVIEWS__74BC79AE1C3D797E");

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
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Review1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Review");
            entity.Property(e => e.ReviewDate).HasColumnType("datetime");

            entity.HasOne(d => d.ByPlayer).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ByPlayerId)
                .HasConstraintName("FK__REVIEWS__ByPlaye__2FCF1A8A");

            entity.HasOne(d => d.Game).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.GameId)
                .HasConstraintName("FK__REVIEWS__GameID__30C33EC3");
        });

        modelBuilder.Entity<Tester>(entity =>
        {
            entity.HasKey(e => e.TesterId).HasName("PK__TESTERS__61EB7DFBBAA18663");

            entity.ToTable("TESTERS");

            entity.HasIndex(e => e.Email, "TesterEmailIndex");

            entity.HasIndex(e => e.Email, "UQ__TESTERS__A9D1053466454D8C").IsUnique();

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
            entity.HasKey(e => new { e.GameId, e.TesterId }).HasName("PK__TESTERS___8CA620024A4B313F");

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
                .HasConstraintName("FK__TESTERS_A__GameI__3C34F16F");

            entity.HasOne(d => d.Tester).WithMany(p => p.TestersAccesses)
                .HasForeignKey(d => d.TesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TESTERS_A__Teste__3B40CD36");
        });

        modelBuilder.Entity<WorksOn>(entity =>
        {
            entity.HasKey(e => new { e.DevId, e.GameId }).HasName("PK__WORKS_ON__1BBE1793903DD602");

            entity.ToTable("WORKS_ON");

            entity.Property(e => e.DevId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("DevID");
            entity.Property(e => e.GameId)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("GameID");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Dev).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.DevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__DevID__25518C17");

            entity.HasOne(d => d.Game).WithMany(p => p.WorksOns)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WORKS_ON__GameID__2645B050");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
