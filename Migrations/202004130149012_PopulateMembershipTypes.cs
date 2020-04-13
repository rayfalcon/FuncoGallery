namespace FuncoGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Type, Fee, DiscountRate) VALUES (1, 3, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Type, Fee, DiscountRate) VALUES (2, 6, 10, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Type, Fee, DiscountRate) VALUES (3, 9, 30, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Type, Fee, DiscountRate) VALUES (4, 12, 45, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
