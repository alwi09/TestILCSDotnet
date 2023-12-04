using Microsoft.EntityFrameworkCore;

namespace TestDotnet.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Pelabuhan> Pelabuhans {get; set;}
        public DbSet<Barang> Barangs {get; set;}
        public DbSet<Negara> Negaras {get; set;}
        public DbSet<Harga> Hargas {get; set;}
        public DbSet<Tarif> Tarifs {get; set;}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
            Pelabuhans = Set<Pelabuhan>();
            Barangs = Set<Barang>();
            Negaras = Set<Negara>();
            Hargas = Set<Harga>();
            Tarifs = Set<Tarif>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Harga>()
                .HasKey(h => h.HargaID);

            modelBuilder.Entity<Tarif>()
                .HasKey(t => t.TarifID);

            modelBuilder.Entity<Barang>()
                .HasKey(b => b.BarangID);

            modelBuilder.Entity<Barang>()
                .HasOne(b => b.Harga)
                .WithOne(h => h.Barang)
                .HasForeignKey<Harga>(h => h.BarangID);

            modelBuilder.Entity<Barang>()
                .HasOne(b => b.Tarif)
                .WithOne(t => t.Barang)
                .HasForeignKey<Tarif>(t => t.BarangID);
        }
    }
}