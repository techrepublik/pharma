using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class OrderDetailManager
    {
        public static DataRepository<OrderDetail> _d;

        public static int Save(OrderDetail orderDetail)
        {
            var a = new OrderDetail
            {
                OrderDetailId = orderDetail.OrderDetailId,
                OrderId = orderDetail.OrderId,
                OrderDetailPrice = orderDetail.OrderDetailPrice,
                OrderDetailIsActive = orderDetail.OrderDetailIsActive,
                OrderDetailDiscount = orderDetail.OrderDetailDiscount,
                OrderDetailQnty = orderDetail.OrderDetailQnty
            };

            using (_d = new DataRepository<OrderDetail>())
            {
                if (orderDetail.OrderDetailId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.OrderDetailId;
        }

        public static bool Delete(OrderDetail orderDetail)
        {
            using (_d = new DataRepository<OrderDetail>())
            {
                _d.Delete(orderDetail);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<OrderDetail>())
            {
                _d.Delete(d => d.OrderDetailId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<OrderDetail> GetAll()
        {
            using (_d = new DataRepository<OrderDetail>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
