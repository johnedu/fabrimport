using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Project.Authorization.Roles;
using Project.Authorization.Users;
using Project.Chat;
using Project.EntityFramework.Mappings;
using Project.Friendships;
using Project.MultiTenancy;
using Project.Storage;

namespace Project.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class ProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public ProjectDbContext()
            : base("Default")
        {
            
        }

        public ProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public ProjectDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public ProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyPhoneMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new InventoryInputMap());
            modelBuilder.Configurations.Add(new InventoryOutputMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoicePaymentMap());
            modelBuilder.Configurations.Add(new InvoiceProductMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderProductMap());
            modelBuilder.Configurations.Add(new ParameterMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonPhoneMap());
            modelBuilder.Configurations.Add(new PersonAddressMap());
            modelBuilder.Configurations.Add(new PhoneMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductPriceMap());
            modelBuilder.Configurations.Add(new ProviderMap());
            modelBuilder.Configurations.Add(new SaleInvoiceMap());
            modelBuilder.Configurations.Add(new SaleInvoicePaymentMap());
            modelBuilder.Configurations.Add(new SetProductMap());
            modelBuilder.Configurations.Add(new SpendingMap());
            modelBuilder.Configurations.Add(new SpendingPaymentMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new TypeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
