using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    class EFBackUserRepository : IUserRepository
    {
        EFDbBackContext context = new EFDbBackContext();
        public IEnumerable<User> Users
        {
            get { return context.Users; }
            set { }
        }
        public void Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void Update(User user)
        {
            context.Users.Attach(user);
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

