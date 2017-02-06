using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class ProductQuantityManager
    {
        public static DataRepository<ProductQuantity> _d;

        public static int Save(ProductQuantity productQuantity)
        {
            var a = new ProductQuantity
            {
                ProductQuantityId = productQuantity.ProductQuantityId,
                ProductQuantityDate = productQuantity.ProductQuantityDate,
                ProductManufactureDate = productQuantity.ProductManufactureDate,
                ProductQuantityExpiryDate = productQuantity.ProductQuantityExpiryDate,
                ProductQuanitityCost = productQuantity.ProductQuanitityCost,
                ProductQuantityPrice = productQuantity.ProductQuantityPrice,
                ProductQuantityQnty = productQuantity.ProductQuantityQnty,
                ProductQuantityIsActive = productQuantity.ProductQuantityIsActive,
                ProductQuantityIsDiscounted = productQuantity.ProductQuantityIsDiscounted,
                ProductQuantityIsExpired = productQuantity.ProductQuantityIsExpired,
                ProductId = productQuantity.ProductId,
                PackingId = productQuantity.PackingId
            };

            using (_d = new DataRepository<ProductQuantity>())
            {
                if (productQuantity.ProductQuantityId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ProductQuantityId;
        }

        public static bool Delete(ProductQuantity productQuantity)
        {
            using (_d = new DataRepository<ProductQuantity>())
            {
                _d.Delete(productQuantity);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<ProductQuantity>())
            {
                _d.Delete(d => d.ProductQuantityId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<ProductQuantity> GetAll()
        {
            using (_d = new DataRepository<ProductQuantity>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
        public static List<ProductQuantity> GetAll(int iId)
        {
            using (_d = new DataRepository<ProductQuantity>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.ProductId == iId).OrderByDescending(o => o.ProductQuantityDate).ToList();
            }
        }
    }
}
