namespace CliniSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFlagColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Children", "IsSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Children", "IsSelected");
        }
    }
}
