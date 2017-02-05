using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class DrugTypeManager
    {
        public static DataRepository<DrugType> _d;

        public static int Save(DrugType drugType)
        {
            var a = new DrugType
            {
                DrugTypeId = drugType.DrugTypeId,
                DrugTypeName = drugType.DrugTypeName
            };

            using (_d = new DataRepository<DrugType>())
            {
                if (drugType.DrugTypeId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.DrugTypeId;
        }

        public static bool Delete(DrugType drugType)
        {
            using (_d = new DataRepository<DrugType>())
            {
                _d.Delete(drugType);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<DrugType>())
            {
                _d.Delete(d => d.DrugTypeId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<DrugType> GetAll()
        {
            using (_d = new DataRepository<DrugType>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
