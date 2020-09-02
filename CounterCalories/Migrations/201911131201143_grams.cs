namespace CounterCalories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class grams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "GramsToLose", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "DestWeight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DestWeight", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "GramsToLose");
        }
    }
}
