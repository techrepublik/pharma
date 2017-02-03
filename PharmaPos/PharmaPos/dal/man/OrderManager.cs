using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class OrderManager
    {
        public static DataRepository<Order> _d;

        public static int Save(Order order)
        {
            var a = new Order
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                OrderDetails = order.OrderDetails,
                OrderIsActive = order.OrderIsActive,
                OrderType = order.OrderType,
                CustomerId = order.CustomerId,
                UserId = order.UserId,
            };

            using (_d = new DataRepository<Order>())
            {
                if (order.CustomerId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.OrderId;
        }

        public static bool Delete(Order order)
        {
            using (_d = new DataRepository<Order>())
            {
                _d.Delete(order);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Order>())
            {
                _d.Delete(d => d.CustomerId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Order> GetAll()
        {
            using (_d = new DataRepository<Order>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
