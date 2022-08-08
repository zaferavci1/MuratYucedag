namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteKategoryDetayColumnInKategoriesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategories", "KategoriDetay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategories", "KategoriDetay", c => c.String());
        }
    }
}
