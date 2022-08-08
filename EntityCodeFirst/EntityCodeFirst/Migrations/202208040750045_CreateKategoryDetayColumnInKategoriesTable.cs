namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKategoryDetayColumnInKategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategories", "KategoriDetay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategories", "KategoriDetay");
        }
    }
}
