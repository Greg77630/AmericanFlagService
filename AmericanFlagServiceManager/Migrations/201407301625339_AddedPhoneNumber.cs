namespace AmericanFlagServiceManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Phone", c => c.String());
            AddColumn("dbo.Contacts", "Subscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Subscribed");
            DropColumn("dbo.Contacts", "Phone");
        }
    }
}
