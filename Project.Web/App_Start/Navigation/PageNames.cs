namespace Project.Web.Navigation
{
    public static class PageNames
    {
        public static class App
        {
            public static class Common
            {
                public const string Administration = "Administration";
                public const string Roles = "Administration.Roles";
                public const string Users = "Administration.Users";
                public const string AuditLogs = "Administration.AuditLogs";
                public const string OrganizationUnits = "Administration.OrganizationUnits";
                public const string Languages = "Administration.Languages";
            }

            public static class Host
            {
                public const string Tenants = "Tenants";
                public const string Editions = "Editions";
                public const string Maintenance = "Administration.Maintenance";
                public const string Settings = "Administration.Settings.Host";
            }

            public static class Tenant
            {
                public const string Dashboard = "Dashboard.Tenant";
                public const string Settings = "Administration.Settings.Tenant";

                public const string General = "General";
                public const string Zoning = "General.Zoning";
                public const string Products = "General.Products";
                public const string Customers = "Customers.Customers";
                public const string Employees = "Customers.Employees";
                public const string Providers = "Customers.Providers";

                public const string Sales = "Sales";
                public const string Orders = "Sales.Orders";
                public const string Invoices = "Sales.Invoices";
                public const string Inventory = "Sales.Inventory";
            }
        }

        public static class Frontend
        {
            public const string Home = "Frontend.Home";
            public const string About = "Frontend.About";
        }
    }
}