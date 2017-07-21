using System.Data.Entity.Migrations;

namespace Kuzey.DAL.Migrations
{
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.SiparisDetaylari",
                    c => new
                    {
                        SiparisId = c.Int(false),
                        UrunId = c.Int(false),
                        UrunFiyati = c.Decimal(false, 18, 2),
                        Adet = c.Short(false),
                        Indirim = c.Double(false)
                    })
                .PrimaryKey(t => new {t.SiparisId, t.UrunId})
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);

            CreateTable(
                    "dbo.Siparisler",
                    c => new
                    {
                        Id = c.Int(false, true),
                        SiparisTarihi = c.DateTime(false),
                        IstenenTarih = c.DateTime(false),
                        Navlun = c.Decimal(false, 18, 2),
                        Adres = c.String(false, 250)
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylari", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylari", "SiparisId", "dbo.Siparisler");
            DropIndex("dbo.SiparisDetaylari", new[] {"UrunId"});
            DropIndex("dbo.SiparisDetaylari", new[] {"SiparisId"});
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylari");
        }
    }
}