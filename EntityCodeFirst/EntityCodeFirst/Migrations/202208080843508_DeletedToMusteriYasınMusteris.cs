namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedToMusteriYasınMusteris : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Musteris", "MusteriYas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriYas", c => c.String());
        }
    }
}
