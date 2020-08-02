namespace Project.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class migracion_septiembre_2019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Address_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.city", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.city",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_City_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.department", t => t.DepartmentId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Department_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.country", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ISOCode = c.String(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Country_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.phone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        CityId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Phone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.type", t => t.TypeId)
                .ForeignKey("dbo.city", t => t.CityId)
                .Index(t => t.CityId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.company_phone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        PhoneId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CompanyPhone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.company", t => t.CompanyId)
                .ForeignKey("dbo.phone", t => t.PhoneId)
                .Index(t => t.CompanyId)
                .Index(t => t.PhoneId);
            
            CreateTable(
                "dbo.company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AddressId = c.Int(nullable: false),
                        DocumentTypeId = c.Int(),
                        DocumentNumber = c.String(),
                        Email = c.String(),
                        RepresentanteId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Company_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.type", t => t.DocumentTypeId)
                .ForeignKey("dbo.person", t => t.RepresentanteId, cascadeDelete: true)
                .ForeignKey("dbo.address", t => t.AddressId)
                .Index(t => t.AddressId)
                .Index(t => t.DocumentTypeId)
                .Index(t => t.RepresentanteId);
            
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(),
                        CompanyId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Customer_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.person", t => t.PersonId)
                .ForeignKey("dbo.company", t => t.CompanyId)
                .Index(t => t.PersonId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        OrderStateId = c.Int(nullable: false),
                        CostValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(),
                        DeliveredDate = c.DateTime(),
                        CancelledDate = c.DateTime(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Order_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.employee", t => t.EmployeeId)
                .ForeignKey("dbo.state", t => t.OrderStateId)
                .ForeignKey("dbo.customer", t => t.CustomerId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId)
                .Index(t => t.OrderStateId);
            
            CreateTable(
                "dbo.employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        UserId = c.Long(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Employee_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.person", t => t.PersonId)
                .ForeignKey("dbo.AbpUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        SecondLastName = c.String(),
                        DocumentTypeId = c.Int(),
                        DocumentNumber = c.String(),
                        BirthdayDate = c.DateTime(),
                        Gender = c.String(),
                        AddressId = c.Int(nullable: false),
                        Email = c.String(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Person_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.type", t => t.DocumentTypeId)
                .ForeignKey("dbo.address", t => t.AddressId)
                .Index(t => t.DocumentTypeId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParameterId = c.Int(nullable: false),
                        Locked = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Type_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.parameter", t => t.ParameterId)
                .Index(t => t.ParameterId);
            
            CreateTable(
                "dbo.parameter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Parameter_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.state",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParameterId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_State_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.parameter", t => t.ParameterId)
                .Index(t => t.ParameterId);
            
            CreateTable(
                "dbo.inventory_input",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceProductId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        QuantitySold = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        SoldDate = c.DateTime(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventoryInput_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.invoice_product", t => t.InvoiceProductId)
                .ForeignKey("dbo.state", t => t.StateId)
                .Index(t => t.InvoiceProductId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.invoice_product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        InvoiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        RealQuantity = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoiceProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.invoice", t => t.InvoiceId)
                .ForeignKey("dbo.product", t => t.ProductId)
                .Index(t => t.ProductId)
                .Index(t => t.InvoiceId);
            
            CreateTable(
                "dbo.invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProviderId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Invoice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.provider", t => t.ProviderId)
                .ForeignKey("dbo.state", t => t.StateId)
                .Index(t => t.ProviderId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.invoice_payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoicePayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.invoice", t => t.InvoiceId)
                .ForeignKey("dbo.state", t => t.StateId)
                .Index(t => t.InvoiceId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.spending",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TypeId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        InvoiceId = c.Int(),
                        OrderId = c.Int(),
                        PersonId = c.Int(),
                        CompanyId = c.Int(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Spending_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.company", t => t.CompanyId)
                .ForeignKey("dbo.invoice", t => t.InvoiceId)
                .ForeignKey("dbo.state", t => t.StateId)
                .ForeignKey("dbo.type", t => t.TypeId)
                .ForeignKey("dbo.person", t => t.PersonId)
                .ForeignKey("dbo.order", t => t.OrderId)
                .Index(t => t.TypeId)
                .Index(t => t.StateId)
                .Index(t => t.InvoiceId)
                .Index(t => t.OrderId)
                .Index(t => t.PersonId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.spending_payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SpendingId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SpendingPayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.spending", t => t.SpendingId)
                .ForeignKey("dbo.state", t => t.StateId)
                .Index(t => t.SpendingId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.provider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(),
                        CompanyId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Provider_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.company", t => t.CompanyId)
                .ForeignKey("dbo.person", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Code = c.String(),
                        QuantityInStock = c.Int(nullable: false),
                        IsSet = c.Boolean(nullable: false),
                        ProductCategoryId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Product_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.product_category", t => t.ProductCategoryId)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.order_product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_OrderProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.product", t => t.ProductId)
                .ForeignKey("dbo.order", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.inventory_output",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Earnings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventoryOutput_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.order_product", t => t.OrderProductId)
                .Index(t => t.OrderProductId);
            
            CreateTable(
                "dbo.product_category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        LastCodeNumber = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ProductCategory_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.product_price",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ProductPrice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.product", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.set_product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SetProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.product", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.sale_invoice_payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleInvoiceId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SaleInvoicePayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.sale_invoice", t => t.SaleInvoiceId)
                .ForeignKey("dbo.state", t => t.StateId)
                .Index(t => t.SaleInvoiceId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.sale_invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        PaymentDate = c.DateTime(),
                        CancelledDate = c.DateTime(),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SaleInvoice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.address", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.state", t => t.StateId)
                .ForeignKey("dbo.order", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.StateId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.person_phone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        PhoneId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TenantId = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonPhone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.person", t => t.PersonId)
                .ForeignKey("dbo.phone", t => t.PhoneId)
                .Index(t => t.PersonId)
                .Index(t => t.PhoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.person", "AddressId", "dbo.address");
            DropForeignKey("dbo.company", "AddressId", "dbo.address");
            DropForeignKey("dbo.phone", "CityId", "dbo.city");
            DropForeignKey("dbo.person_phone", "PhoneId", "dbo.phone");
            DropForeignKey("dbo.company_phone", "PhoneId", "dbo.phone");
            DropForeignKey("dbo.company", "RepresentanteId", "dbo.person");
            DropForeignKey("dbo.company_phone", "CompanyId", "dbo.company");
            DropForeignKey("dbo.customer", "CompanyId", "dbo.company");
            DropForeignKey("dbo.order", "CustomerId", "dbo.customer");
            DropForeignKey("dbo.spending", "OrderId", "dbo.order");
            DropForeignKey("dbo.sale_invoice", "OrderId", "dbo.order");
            DropForeignKey("dbo.order_product", "OrderId", "dbo.order");
            DropForeignKey("dbo.employee", "UserId", "dbo.AbpUsers");
            DropForeignKey("dbo.provider", "PersonId", "dbo.person");
            DropForeignKey("dbo.person_phone", "PersonId", "dbo.person");
            DropForeignKey("dbo.spending", "PersonId", "dbo.person");
            DropForeignKey("dbo.employee", "PersonId", "dbo.person");
            DropForeignKey("dbo.spending", "TypeId", "dbo.type");
            DropForeignKey("dbo.phone", "TypeId", "dbo.type");
            DropForeignKey("dbo.person", "DocumentTypeId", "dbo.type");
            DropForeignKey("dbo.type", "ParameterId", "dbo.parameter");
            DropForeignKey("dbo.state", "ParameterId", "dbo.parameter");
            DropForeignKey("dbo.spending", "StateId", "dbo.state");
            DropForeignKey("dbo.spending_payment", "StateId", "dbo.state");
            DropForeignKey("dbo.sale_invoice", "StateId", "dbo.state");
            DropForeignKey("dbo.sale_invoice_payment", "StateId", "dbo.state");
            DropForeignKey("dbo.sale_invoice_payment", "SaleInvoiceId", "dbo.sale_invoice");
            DropForeignKey("dbo.sale_invoice", "AddressId", "dbo.address");
            DropForeignKey("dbo.order", "OrderStateId", "dbo.state");
            DropForeignKey("dbo.invoice", "StateId", "dbo.state");
            DropForeignKey("dbo.invoice_payment", "StateId", "dbo.state");
            DropForeignKey("dbo.inventory_input", "StateId", "dbo.state");
            DropForeignKey("dbo.set_product", "ProductId", "dbo.product");
            DropForeignKey("dbo.product_price", "ProductId", "dbo.product");
            DropForeignKey("dbo.product", "ProductCategoryId", "dbo.product_category");
            DropForeignKey("dbo.order_product", "ProductId", "dbo.product");
            DropForeignKey("dbo.inventory_output", "OrderProductId", "dbo.order_product");
            DropForeignKey("dbo.invoice_product", "ProductId", "dbo.product");
            DropForeignKey("dbo.invoice", "ProviderId", "dbo.provider");
            DropForeignKey("dbo.provider", "CompanyId", "dbo.company");
            DropForeignKey("dbo.spending", "InvoiceId", "dbo.invoice");
            DropForeignKey("dbo.spending_payment", "SpendingId", "dbo.spending");
            DropForeignKey("dbo.spending", "CompanyId", "dbo.company");
            DropForeignKey("dbo.invoice_product", "InvoiceId", "dbo.invoice");
            DropForeignKey("dbo.invoice_payment", "InvoiceId", "dbo.invoice");
            DropForeignKey("dbo.inventory_input", "InvoiceProductId", "dbo.invoice_product");
            DropForeignKey("dbo.company", "DocumentTypeId", "dbo.type");
            DropForeignKey("dbo.customer", "PersonId", "dbo.person");
            DropForeignKey("dbo.order", "EmployeeId", "dbo.employee");
            DropForeignKey("dbo.department", "CountryId", "dbo.country");
            DropForeignKey("dbo.city", "DepartmentId", "dbo.department");
            DropForeignKey("dbo.address", "CityId", "dbo.city");
            DropIndex("dbo.person_phone", new[] { "PhoneId" });
            DropIndex("dbo.person_phone", new[] { "PersonId" });
            DropIndex("dbo.sale_invoice", new[] { "AddressId" });
            DropIndex("dbo.sale_invoice", new[] { "StateId" });
            DropIndex("dbo.sale_invoice", new[] { "OrderId" });
            DropIndex("dbo.sale_invoice_payment", new[] { "StateId" });
            DropIndex("dbo.sale_invoice_payment", new[] { "SaleInvoiceId" });
            DropIndex("dbo.set_product", new[] { "ProductId" });
            DropIndex("dbo.product_price", new[] { "ProductId" });
            DropIndex("dbo.inventory_output", new[] { "OrderProductId" });
            DropIndex("dbo.order_product", new[] { "ProductId" });
            DropIndex("dbo.order_product", new[] { "OrderId" });
            DropIndex("dbo.product", new[] { "ProductCategoryId" });
            DropIndex("dbo.provider", new[] { "CompanyId" });
            DropIndex("dbo.provider", new[] { "PersonId" });
            DropIndex("dbo.spending_payment", new[] { "StateId" });
            DropIndex("dbo.spending_payment", new[] { "SpendingId" });
            DropIndex("dbo.spending", new[] { "CompanyId" });
            DropIndex("dbo.spending", new[] { "PersonId" });
            DropIndex("dbo.spending", new[] { "OrderId" });
            DropIndex("dbo.spending", new[] { "InvoiceId" });
            DropIndex("dbo.spending", new[] { "StateId" });
            DropIndex("dbo.spending", new[] { "TypeId" });
            DropIndex("dbo.invoice_payment", new[] { "StateId" });
            DropIndex("dbo.invoice_payment", new[] { "InvoiceId" });
            DropIndex("dbo.invoice", new[] { "StateId" });
            DropIndex("dbo.invoice", new[] { "ProviderId" });
            DropIndex("dbo.invoice_product", new[] { "InvoiceId" });
            DropIndex("dbo.invoice_product", new[] { "ProductId" });
            DropIndex("dbo.inventory_input", new[] { "StateId" });
            DropIndex("dbo.inventory_input", new[] { "InvoiceProductId" });
            DropIndex("dbo.state", new[] { "ParameterId" });
            DropIndex("dbo.type", new[] { "ParameterId" });
            DropIndex("dbo.person", new[] { "AddressId" });
            DropIndex("dbo.person", new[] { "DocumentTypeId" });
            DropIndex("dbo.employee", new[] { "UserId" });
            DropIndex("dbo.employee", new[] { "PersonId" });
            DropIndex("dbo.order", new[] { "OrderStateId" });
            DropIndex("dbo.order", new[] { "CustomerId" });
            DropIndex("dbo.order", new[] { "EmployeeId" });
            DropIndex("dbo.customer", new[] { "CompanyId" });
            DropIndex("dbo.customer", new[] { "PersonId" });
            DropIndex("dbo.company", new[] { "RepresentanteId" });
            DropIndex("dbo.company", new[] { "DocumentTypeId" });
            DropIndex("dbo.company", new[] { "AddressId" });
            DropIndex("dbo.company_phone", new[] { "PhoneId" });
            DropIndex("dbo.company_phone", new[] { "CompanyId" });
            DropIndex("dbo.phone", new[] { "TypeId" });
            DropIndex("dbo.phone", new[] { "CityId" });
            DropIndex("dbo.department", new[] { "CountryId" });
            DropIndex("dbo.city", new[] { "DepartmentId" });
            DropIndex("dbo.address", new[] { "CityId" });
            DropTable("dbo.person_phone",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_PersonPhone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.sale_invoice",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SaleInvoice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.sale_invoice_payment",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SaleInvoicePayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.set_product",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SetProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.product_price",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ProductPrice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.product_category",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ProductCategory_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.inventory_output",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventoryOutput_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.order_product",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_OrderProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.product",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Product_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.provider",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Provider_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.spending_payment",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SpendingPayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.spending",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Spending_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.invoice_payment",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoicePayment_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.invoice",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Invoice_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.invoice_product",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InvoiceProduct_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.inventory_input",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_InventoryInput_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.state",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_State_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.parameter",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Parameter_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.type",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Type_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.person",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Person_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.employee",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Employee_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.order",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Order_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.customer",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Customer_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.company",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Company_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.company_phone",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_CompanyPhone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.phone",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Phone_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.country",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Country_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.department",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Department_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.city",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_City_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.address",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Address_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
