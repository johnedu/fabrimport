using EntityFramework.DynamicFilters;
using Project.EntityFramework;

namespace Project.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ProjectDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(ProjectDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
