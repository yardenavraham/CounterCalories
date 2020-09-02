namespace CounterCalories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "Meal", c => c.String());
            AlterColumn("dbo.Foods", "Day", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "Day", c => c.Int(nullable: false));
            AlterColumn("dbo.Foods", "Meal", c => c.Int(nullable: false));
        }
    }
}
