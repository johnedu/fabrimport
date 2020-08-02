using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class CompanyPhoneMap : MultiTenantMap<CompanyPhone>
    {
        public CompanyPhoneMap()
        {

            //  TABLE NAME
            ToTable("company_phone");
        }
    }
}