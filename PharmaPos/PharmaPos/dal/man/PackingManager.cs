using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class PackingManager
    {
        public static DataRepository<Packing> _d;

        public static int Save(Packing packing)
        {
            var a = new Packing
            {
                PackingId = packing.PackingId,
                PackingName = packing.PackingName
            };

            using (_d = new DataRepository<Packing>())
            {
                if (packing.PackingId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.PackingId;
        }

        public static bool Delete(Packing packing)
        {
            using (_d = new DataRepository<Packing>())
            {
                _d.Delete(packing);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Packing>())
            {
                _d.Delete(d => d.PackingId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Packing> GetAll()
        {
            using (_d = new DataRepository<Packing>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
