using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class VoidReasonManager
    {
        public static DataRepository<VoidReason> _d;

        public static int Save(VoidReason voidReason)
        {
            var a = new VoidReason
            {
                VoidReasonId = voidReason.VoidReasonId,
                VoidReasonReason = voidReason.VoidReasonReason
            };

            using (_d = new DataRepository<VoidReason>())
            {
                if (voidReason.VoidReasonId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.VoidReasonId;
        }

        public static bool Delete(VoidReason voidReason)
        {
            using (_d = new DataRepository<VoidReason>())
            {
                _d.Delete(voidReason);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<VoidReason>())
            {
                _d.Delete(d => d.VoidReasonId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<VoidReason> GetAll()
        {
            using (_d = new DataRepository<VoidReason>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
