using System.Data.Entity.Migrations;

namespace Kuzey.DAL.Migrations
{
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Kategoriler",
                    c => new
                    {
                        Id = c.Int(false, true),
                        KategoriAdi = c.String(false, 25),
                        Aciklama = c.String()
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Kategoriler");
        }
    }
}