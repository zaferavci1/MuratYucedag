namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKatergoryADitoKAtegoryAdInKAtegories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategories", "KategoryAd", c => c.String());
            Sql("Update Kategories Set KategoryAd=KategoryAdi");
            DropColumn("dbo.Kategories", "KategoryAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategories", "KategoryAdi", c => c.String());
            Sql("Update Kategories Set KategoryAdi=KategoryAd");
            DropColumn("dbo.Kategories", "KategoryAd");
        }
    }
}
