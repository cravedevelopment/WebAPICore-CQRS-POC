using System.Linq;
using Project.Domain.Interfaces;
using Project.Domain.Models;
using Project.Infra.Data.Context;

namespace Project.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ProjectContext context) : base(context)
        {
        }

        public Customer GetByEmail(string email)
        {
            return Find(c => c.Email == email).FirstOrDefault();
        }
    }
}