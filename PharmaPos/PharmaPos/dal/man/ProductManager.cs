using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class ProductManager
    {
        public static DataRepository<Product> _d;

        public static int Save(Product product)
        {
            var a = new Product
            {
                ProductId = product.ProductId,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductGenericName = product.ProductGenericName,
                ProductInstruction = product.ProductInstruction,
                ProductAlertCount = product.ProductAlertCount,
                ProductLotNo = product.ProductLotNo,
                ProductPicture = product.ProductPicture,
                ProductQuantities = product.ProductQuantities,
                CategoryId = product.CategoryId,
                UnitId = product.UnitId,
                SupplierId = product.SupplierId,
                DrugTypeId = product.DrugTypeId
            };

            using (_d = new DataRepository<Product>())
            {
                if (product.ProductId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ProductId;
        }

        public static bool Delete(Product product)
        {
            using (_d = new DataRepository<Product>())
            {
                _d.Delete(product);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Product>())
            {
                _d.Delete(d => d.CategoryId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Product> GetAll()
        {
            using (_d = new DataRepository<Product>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
