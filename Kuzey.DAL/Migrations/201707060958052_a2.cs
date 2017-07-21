using System.Data.Entity.Migrations;

namespace Kuzey.DAL.Migrations
{
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Urunler",
                    c => new
                    {
                        Id = c.Int(false, true),
                        UrunAdi = c.String(false, 50),
                        Fiyat = c.Decimal(false, 18, 2),
                        KategoriId = c.Int(false),
                        SatistaMi = c.Boolean(false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, true)
                .Index(t => t.KategoriId);

            AddColumn("dbo.Kategoriler", "EklenmeZamani", c => c.DateTime(false));
        }

        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] {"KategoriId"});
            DropColumn("dbo.Kategoriler", "EklenmeZamani");
            DropTable("dbo.Urunler");
        }
    }
}