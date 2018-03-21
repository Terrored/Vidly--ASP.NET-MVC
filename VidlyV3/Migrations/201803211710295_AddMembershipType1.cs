namespace VidlyV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.MembershipTypes", "SignedUpFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SignedUpFee", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
