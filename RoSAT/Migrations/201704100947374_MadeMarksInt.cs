namespace RoSAT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeMarksInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Marks", "InternalMarks", c => c.Int(nullable: false));
            AlterColumn("dbo.Marks", "ExternalMarks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Marks", "ExternalMarks", c => c.Decimal(nullable: false, precision: 3, scale: 0, storeType: "numeric"));
            AlterColumn("dbo.Marks", "InternalMarks", c => c.Decimal(nullable: false, precision: 2, scale: 0, storeType: "numeric"));
        }
    }
}
