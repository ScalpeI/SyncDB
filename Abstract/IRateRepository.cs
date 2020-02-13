using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface IRateRepository
    {
        IEnumerable<Rate> Rates { get; set; }
        void Create(Rate rate);
    }
}