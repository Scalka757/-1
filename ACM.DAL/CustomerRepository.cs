using System.Collections.Generic;
using CMS.BusinessLayer;

namespace CMS.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // TODO: Replace with database query.
            return new Customer(customerId);
        }

        public List<Customer> Retrieve()
        {
            // TODO: Replace with database query.
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            // TODO: Replace with INSERT/UPDATE.
            return customer != null;
        }
    }
}
