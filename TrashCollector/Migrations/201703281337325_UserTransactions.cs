namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTransactions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "pickUpsTransacted", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "pickUpsTransacted");
        }
    }
}
