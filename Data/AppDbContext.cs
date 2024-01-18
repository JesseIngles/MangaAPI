using CelsonApi.Models;
using CelsonApi.Models.Tabelas;
using Microsoft.EntityFrameworkCore;

namespace CelsonApi.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("datasource=app.db; cache=shared");
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbUser>()
            .HasMany(x => x.Avaliacaos)
            .WithOne()
            .HasForeignKey("AvaliacaoId")
            .IsRequired(false);
        
        modelBuilder.Entity<TbManga>()
            .HasMany(x => x.Avaliacaos)
            .WithOne()
            .HasForeignKey("AvaliacaoId")
            .IsRequired(false);

        modelBuilder.Entity<TbManga>()
            .HasMany(x => x.Categories)
            .WithOne()
            .HasForeignKey("CategoriaId")
            .IsRequired(false);
    }*/
    public DbSet<TbUser> Users {get; set;}
    public DbSet<TbManga> Mangas {get; set;}
    public DbSet<TbCategory> Categories {get; set;}
    public DbSet<TbAvaliacao> Avaliacaos {get; set;}
}