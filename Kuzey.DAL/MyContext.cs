using System.Data.Entity;
using Kuzey.Model.Entities;

namespace Kuzey.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=LocalCon")
        {
            Database.CreateIfNotExists();
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylar { get; set; }
    }
}