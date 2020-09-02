namespace CounterCalories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        NameFood = c.String(nullable: false, maxLength: 128),
                        Meal = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Calories = c.Int(nullable: false),
                        Nutrients = c.String(),
                    })
                .PrimaryKey(t => new { t.UserName, t.NameFood });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Password = c.String(),
                        BirthYear = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        GramsToLose = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        ActivityLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Foods");
        }
    }
}
