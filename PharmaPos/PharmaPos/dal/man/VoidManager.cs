using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class VoidManager
    {
        public static DataRepository<Void> _d;

        public static int Save(Void voids)
        {
            var a = new Void
            {
                VoidId = voids.VoidId,
                VoidDate = voids.VoidDate,
                VoidTime = voids.VoidTime,
                VoidAllOrder = voids.VoidAllOrder,
                OrderDetailId = voids.OrderDetailId,
                OrderId = voids.OrderId,
                UserId = voids.UserId,
                VoidReasonId = voids.VoidReasonId
            };

            using (_d = new DataRepository<Void>())
            {
                if (voids.VoidId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.VoidId;
        }

        public static bool Delete(Void voids)
        {
            using (_d = new DataRepository<Void>())
            {
                _d.Delete(voids);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Void>())
            {
                _d.Delete(d => d.VoidId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Void> GetAll()
        {
            using (_d = new DataRepository<Void>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

    }
}
