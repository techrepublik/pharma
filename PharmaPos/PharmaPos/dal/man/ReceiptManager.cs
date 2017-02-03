using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class ReceiptManager
    {
        public static DataRepository<Receipt> _d;

        public static int Save(Receipt receipt)
        {
            var a = new Receipt
            {
                ReceiptId = receipt.ReceiptId,
                ReceiptDate = receipt.ReceiptDate,
                ReceiptAmount = receipt.ReceiptAmount,
                ReceiptIsActive = receipt.ReceiptIsActive,
                ReceiptNo = receipt.ReceiptNo
            };

            using (_d = new DataRepository<Receipt>())
            {
                if (receipt.ReceiptId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ReceiptId;
        }

        public static bool Delete(Receipt receipt)
        {
            using (_d = new DataRepository<Receipt>())
            {
                _d.Delete(receipt);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Receipt>())
            {
                _d.Delete(d => d.ReceiptId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Receipt> GetAll()
        {
            using (_d = new DataRepository<Receipt>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
