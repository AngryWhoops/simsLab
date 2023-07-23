using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class ApplicationContext : DbContext
{
    public DbSet<AppFile> AppFiles { get; set; } = null!;
    public DbSet<GroundType> GroundTypes { get; set; } = null!;
    public DbSet<Image> Images { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<PostPrewiew> PostPrewiews { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=simslib;Username=simba;Password=123456");
        optionsBuilder.UseInMemoryDatabase("inmemoryDB");
    }
    /* Прописываем отношения */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(e => e.User)
            .WithMany(e => e.Posts);
        modelBuilder.Entity<Post>()
            .HasMany(e => e.Tags)
            .WithMany(e => e.Posts);
        modelBuilder.Entity<Post>()
            .HasOne(e => e.GroundType)
            .WithMany(e => e.Posts);
        modelBuilder.Entity<Post>()
            .HasOne(e => e.Prewiew)
            .WithOne(e => e.Post)
            .HasForeignKey<PostPrewiew>(e => e.PostId);
        modelBuilder.Entity<Post>()
            .HasOne(e => e.AppFile)
            .WithOne(e => e.Post)
            .HasForeignKey<AppFile>(e => e.PostId);
        modelBuilder.Entity<Post>()
            .HasMany(e => e.Images)
            .WithOne(e => e.Post);

        modelBuilder.Entity<AppFile>()
            .HasOne(e => e.Post)
            .WithOne(e => e.AppFile);

        modelBuilder.Entity<GroundType>()
            .HasMany(e => e.Posts)
            .WithOne(e => e.GroundType);

        modelBuilder.Entity<Image>()
            .HasOne(e => e.Post)
            .WithMany(e => e.Images);

        modelBuilder.Entity<PostPrewiew>()
            .HasOne(e => e.Post)
            .WithOne(e => e.Prewiew);

        modelBuilder.Entity<Tag>()
            .HasMany(e => e.Posts)
            .WithMany(e => e.Tags);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Posts)
            .WithOne(e => e.User);
    }
}