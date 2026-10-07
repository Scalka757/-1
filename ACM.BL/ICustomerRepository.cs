using System.Collections.Generic;

namespace CMS.BusinessLayer
{
    public interface ICustomerRepository
    {
        Customer Retrieve(int customerId);
        List<Customer> Retrieve();
        bool Save(Customer customer);
    }
}
