using Microsoft.EntityFrameworkCore;

namespace Crm.Data.Context
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }
    }
}
