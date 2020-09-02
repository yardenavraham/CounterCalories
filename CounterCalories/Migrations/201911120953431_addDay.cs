namespace CounterCalories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Day", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Day");
        }
    }
}
