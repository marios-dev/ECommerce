using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Customers.Db
{
    public class CustomersDbContext //:Context
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
