namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickUpDayAsInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PickUpSchedules", "weeklyPickUpDay", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PickUpSchedules", "weeklyPickUpDay", c => c.String());
        }
    }
}
