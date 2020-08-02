namespace Project.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class migracion_julio_2020 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.state", "ParameterId", "dbo.parameter");
            DropForeignKey("dbo.person", "AddressId", "dbo.address");
            DropIndex("dbo.phone", new[] { "CityId" });
            DropIndex("dbo.person", new[] { "AddressId" });
            DropIndex("dbo.state", new[] { "ParameterId" });
            CreateTable(
                "dbo.person_address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonAddress_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.person", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.address", t => t.AddressId)
                .Index(t => t.PersonId)
                .Index(t => t.AddressId);
            
            AddColumn("dbo.address", "IsMain", c => c.Boolean(nullable: false));
            AddColumn("dbo.phone", "CountryId", c => c.Int());
            AddColumn("dbo.person", "FullName", c => c.String());
            AddColumn("dbo.state", "StateTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.state", "Locked", c => c.Boolean(nullable: false));
            AlterColumn("dbo.phone", "CityId", c => c.Int());
            CreateIndex("dbo.phone", "CityId");
            CreateIndex("dbo.phone", "CountryId");
            CreateIndex("dbo.state", "StateTypeId");
            AddForeignKey("dbo.state", "StateTypeId", "dbo.type", "Id");
            AddForeignKey("dbo.phone", "CountryId", "dbo.country", "Id");
            DropColumn("dbo.person", "AddressId");
            DropColumn("dbo.state", "ParameterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.state", "ParameterId", c => c.Int(nullable: false));
            AddColumn("dbo.person", "AddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.person_address", "AddressId", "dbo.address");
            DropForeignKey("dbo.phone", "CountryId", "dbo.country");
            DropForeignKey("dbo.state", "StateTypeId", "dbo.type");
            DropForeignKey("dbo.person_address", "PersonId", "dbo.person");
            DropIndex("dbo.state", new[] { "StateTypeId" });
            DropIndex("dbo.person_address", new[] { "AddressId" });
            DropIndex("dbo.person_address", new[] { "PersonId" });
            DropIndex("dbo.phone", new[] { "CountryId" });
            DropIndex("dbo.phone", new[] { "CityId" });
            AlterColumn("dbo.phone", "CityId", c => c.Int(nullable: false));
            DropColumn("dbo.state", "Locked");
            DropColumn("dbo.state", "StateTypeId");
            DropColumn("dbo.person", "FullName");
            DropColumn("dbo.phone", "CountryId");
            DropColumn("dbo.address", "IsMain");
            DropTable("dbo.person_address",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonAddress_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            CreateIndex("dbo.state", "ParameterId");
            CreateIndex("dbo.person", "AddressId");
            CreateIndex("dbo.phone", "CityId");
            AddForeignKey("dbo.person", "AddressId", "dbo.address", "Id");
            AddForeignKey("dbo.state", "ParameterId", "dbo.parameter", "Id");
        }
    }
}
