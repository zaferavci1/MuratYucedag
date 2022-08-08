namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteriTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriYas", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "MusteriYas");
        }
    }
}
