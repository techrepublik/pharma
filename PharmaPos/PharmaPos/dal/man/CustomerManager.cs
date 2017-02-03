using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class CustomerManager
    {
        public static DataRepository<Customer> _d;

        public static int Save(Customer customer)
        {
            var a = new Customer
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                CustomerAddress = customer.CustomerAddress,
                CustomerCode = customer.CustomerCode,
                CustomerContact = customer.CustomerContact,
                CustomerIsActive = customer.CustomerIsActive
            };

            using (_d = new DataRepository<Customer>())
            {
                if (customer.CustomerId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.CustomerId;
        }

        public static bool Delete(Customer customer)
        {
            using (_d = new DataRepository<Customer>())
            {
                _d.Delete(customer);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Customer>())
            {
                _d.Delete(d => d.CustomerId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Customer> GetAll()
        {
            using (_d = new DataRepository<Customer>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
