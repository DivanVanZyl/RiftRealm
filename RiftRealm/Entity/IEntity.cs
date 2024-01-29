using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Entity
{
    public interface IEntity
    {
        public bool IsIndoors { get; }
    }
}
