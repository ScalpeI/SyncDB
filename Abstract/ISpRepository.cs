using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface ISpRepository
    {
        IEnumerable<Sp> Sps { get; set; }
        void Create(Sp sp);
    }
}
