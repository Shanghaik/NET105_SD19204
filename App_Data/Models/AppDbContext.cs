using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext() // Cái này phải viết trước
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        // DbSet - đại diện cho các bảng trong CSDL
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HDCT> HDCTS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SHANGHAIK;Database=SD19204_NET105;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
