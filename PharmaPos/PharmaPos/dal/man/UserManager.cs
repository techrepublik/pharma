using System;
using System.Collections.Generic;
using System.Linq;
using PharmaPos.data;

namespace PharmaPos.dal.man
{
    class UserManager
    {
        public static DataRepository<User> _d;

        public static int Save(User user)
        {
            var a = new User
            {
                UserId = user.UserId,
                UserDate = user.UserDate,
                UserFullName = user.UserFullName,
                UserIsActive = user.UserIsActive,
                UserLevel = user.UserLevel,
                UserName = user.UserName,
                UserPassword = user.UserPassword,
                UserNo = user.UserNo
            };

            using (_d = new DataRepository<User>())
            {
                if (user.UserId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.UserId;
        }

        public static bool Delete(User user)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(user);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(d => d.UserId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<User> GetAll()
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static User GetUser(string username, string password)
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return
                    _d.FirstOrDefault(
                        f => String.Equals(f.UserName, username, StringComparison.CurrentCultureIgnoreCase) && string.Equals(f.UserPassword, password, StringComparison.CurrentCultureIgnoreCase));
            }
        }
    }
}
