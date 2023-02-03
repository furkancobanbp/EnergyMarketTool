using jsonParser.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser
{
    public class context : DbContext
    {
        public DbSet<clsOsosModel> tblOsosVeri { get; set; } 
        public DbSet<clsDagitimModel> tblDagitimBolgeleri { get; set; }
        public DbSet<clsPiyasaFiyatlariModel> tblPiyasaFiyatlari { get; set; }
        public DbSet<clsDgpTalimatOzet> tblDgpOzet { get; set; }
        public DbSet<clsGercekZamanliUretim> tblGercekZamanliUretimler { get; set; }
        public DbSet<clsAuf> tblAuf { get; set; }
        public DbSet<clsGrf> tblGazReferans { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=CeliklerDb;Username=postgres;Password=Fc123456*");
    }
}
