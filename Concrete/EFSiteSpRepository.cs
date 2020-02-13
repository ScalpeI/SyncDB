using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    class EFSiteSpRepository : ISpRepository
    {
        EFDbSiteContext context = new EFDbSiteContext();
        public IEnumerable<Sp> Sps
        {
            get { return context.Sps; }
            set { }
        }
        public void Create(Sp sp)
        {
            context.Sps.Add(sp);
            context.SaveChanges();
        }
    }
}
