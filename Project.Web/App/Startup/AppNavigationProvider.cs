using Abp.Application.Navigation;
using Abp.Localization;
using Project.Authorization;
using Project.Web.Navigation;

namespace Project.Web.App.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class AppNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(new MenuItemDefinition(
                    PageNames.App.Host.Tenants,
                    L("Tenants"),
                    url: "host.tenants",
                    icon: "icon-globe",
                    requiredPermissionName: AppPermissions.Pages_Tenants
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.App.Host.Editions,
                    L("Editions"),
                    url: "host.editions",
                    icon: "icon-grid",
                    requiredPermissionName: AppPermissions.Pages_Editions
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.App.Tenant.Dashboard,
                    L("Dashboard"),
                    url: "tenant.dashboard",
                    icon: "icon-home",
                    requiredPermissionName: AppPermissions.Pages_Tenant_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.App.Tenant.General,
                    L("General"),
                    icon: "fa fa-cogs"
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Zoning,
                        L("GeneralZoning"),
                        url: "general.zoning",
                        icon: "fa fa-map",
                        requiredPermissionName: AppPermissions.Pages_Tenant_General_Zoning
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Products,
                        L("GeneralProducts"),
                        url: "general.products",
                        icon: "fa fa-cog",
                        requiredPermissionName: AppPermissions.Pages_Tenant_General_Products
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Customers,
                        L("GeneralCustomers"),
                        url: "general.customers",
                        icon: "fa fa-users",
                        requiredPermissionName: AppPermissions.Pages_Tenant_General_Customers
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Employees,
                        L("GeneralEmployees"),
                        url: "general.employees",
                        icon: "fa fa-user-circle",
                        requiredPermissionName: AppPermissions.Pages_Tenant_General_Employees
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Providers,
                        L("GeneralProviders"),
                        url: "general.providers",
                        icon: "fa fa-user",
                        requiredPermissionName: AppPermissions.Pages_Tenant_General_Providers
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.App.Tenant.Sales,
                    L("Sales"),
                    icon: "fa fa-diamond"
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Orders,
                        L("SalesOrders"),
                        url: "sales.orders",
                        icon: "fa fa-file-text",
                        requiredPermissionName: AppPermissions.Pages_Tenant_Sales_Orders
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Invoices,
                        L("SalesInvoices"),
                        url: "sales.invoices",
                        icon: "fa fa-file-text-o",
                        requiredPermissionName: AppPermissions.Pages_Tenant_Sales_Invoices
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Inventory,
                        L("SalesInventory"),
                        url: "sales.inventory",
                        icon: "fa fa-list",
                        requiredPermissionName: AppPermissions.Pages_Tenant_Sales_Inventory
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.App.Common.Administration,
                    L("Administration"),
                    icon: "icon-wrench"
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Common.OrganizationUnits,
                        L("OrganizationUnits"),
                        url: "organizationUnits",
                        icon: "icon-layers",
                        requiredPermissionName: AppPermissions.Pages_Administration_OrganizationUnits
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Common.Roles,
                        L("Roles"),
                        url: "roles",
                        icon: "icon-briefcase",
                        requiredPermissionName: AppPermissions.Pages_Administration_Roles
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Common.Users,
                        L("Users"),
                        url: "users",
                        icon: "icon-users",
                        requiredPermissionName: AppPermissions.Pages_Administration_Users
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Common.Languages,
                        L("Languages"),
                        url: "languages",
                        icon: "icon-flag",
                        requiredPermissionName: AppPermissions.Pages_Administration_Languages
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Common.AuditLogs,
                        L("AuditLogs"),
                        url: "auditLogs",
                        icon: "icon-lock",
                        requiredPermissionName: AppPermissions.Pages_Administration_AuditLogs
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Host.Maintenance,
                        L("Maintenance"),
                        url: "host.maintenance",
                        icon: "icon-wrench",
                        requiredPermissionName: AppPermissions.Pages_Administration_Host_Maintenance
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                        PageNames.App.Host.Settings,
                        L("Settings"),
                        url: "host.settings",
                        icon: "icon-settings",
                        requiredPermissionName: AppPermissions.Pages_Administration_Host_Settings
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Settings,
                        L("Settings"),
                        url: "tenant.settings",
                        icon: "icon-settings",
                        requiredPermissionName: AppPermissions.Pages_Administration_Tenant_Settings
                        )
                    ).AddItem(new MenuItemDefinition(
                        PageNames.App.Tenant.Settings,
                        L("RunSeed"),
                        url: "seedConfiguration",
                        icon: "fa fa-play",
                        requiredPermissionName: AppPermissions.Pages_Administration_SeedConfiguration
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ProjectConsts.LocalizationSourceName);
        }
    }
}
