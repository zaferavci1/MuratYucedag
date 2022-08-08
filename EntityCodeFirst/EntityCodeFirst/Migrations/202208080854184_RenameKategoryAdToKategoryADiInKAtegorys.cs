namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoryAdToKategoryADiInKAtegorys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategories", "KategoryAdi", c => c.String());
            DropColumn("dbo.Kategories", "KategoryAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategories", "KategoryAd", c => c.String());
            DropColumn("dbo.Kategories", "KategoryAdi");
        }
    }
}
