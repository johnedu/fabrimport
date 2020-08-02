namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion_julio_2020_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.order_product", "OrderId", "dbo.order");
            AddColumn("dbo.order", "Number", c => c.Int(nullable: false));
            AddForeignKey("dbo.order_product", "OrderId", "dbo.order", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.order_product", "OrderId", "dbo.order");
            DropColumn("dbo.order", "Number");
            AddForeignKey("dbo.order_product", "OrderId", "dbo.order", "Id");
        }
    }
}
