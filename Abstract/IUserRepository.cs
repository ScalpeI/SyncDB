using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; set; }
        void Create(User user);
        void Update(User user);
    }
}
