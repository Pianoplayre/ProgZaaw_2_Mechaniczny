namespace HamburgerMenuDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        carID = c.Int(nullable: false, identity: true),
                        carModelID = c.Int(nullable: false),
                        carType = c.String(),
                        carCategory = c.String(),
                        carDesc = c.String(),
                        carPrice = c.Int(nullable: false),
                        carOwnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.carID);
            
            CreateTable(
                "dbo.CarTechInfo",
                c => new
                    {
                        carModelID = c.Int(nullable: false, identity: true),
                        carMark = c.String(),
                        carModelName = c.String(),
                        carComplectation = c.String(),
                        carPower = c.Int(nullable: false),
                        carGear = c.String(),
                        carEngine = c.Int(nullable: false),
                        carFuelTank = c.String(),
                        carPlaces = c.Int(nullable: false),
                        carFuelConsumption = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.carModelID);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        contractID = c.Int(nullable: false, identity: true),
                        orderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.contractID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderID = c.Int(nullable: false, identity: true),
                        managerID = c.Int(nullable: false),
                        customerID = c.Int(nullable: false),
                        orderStatus = c.String(),
                        price = c.Int(nullable: false),
                        carID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.orderID);
            
            CreateTable(
                "dbo.Requirements",
                c => new
                    {
                        reqID = c.Int(nullable: false, identity: true),
                        customerID = c.Int(nullable: false),
                        carModelID = c.Int(nullable: false),
                        carCategory = c.String(),
                        carPower = c.String(),
                        carGear = c.String(),
                        carEngine = c.String(),
                        carFuelTank = c.String(),
                        carPlaces = c.Int(nullable: false),
                        Budget = c.Int(nullable: false),
                        managerID = c.Int(nullable: false),
                        carID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.reqID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        roleID = c.Int(nullable: false, identity: true),
                        roleName = c.String(),
                        roleDescription = c.String(),
                    })
                .PrimaryKey(t => t.roleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userRoleId = c.Int(nullable: false),
                        userName = c.String(),
                        userEmail = c.String(),
                        userPhone = c.String(),
                        userLogin = c.String(),
                        userPassword = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Requirements");
            DropTable("dbo.Orders");
            DropTable("dbo.Contracts");
            DropTable("dbo.CarTechInfo");
            DropTable("dbo.Cars");
        }
    }
}
