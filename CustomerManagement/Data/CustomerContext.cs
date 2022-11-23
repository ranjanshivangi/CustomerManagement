using Microsoft.EntityFrameworkCore;
using CustomerManagement.Models;

namespace CustomerManagement.Data
{
    public class CustomerContext: DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
           : base(options)
        {

        }

        public DbSet<CustomerManagement.Models.Customer> Customers { get; set; }

        public DbSet<CustomerManagement.Models.Orders> Orders { get; set; }
    }
}
