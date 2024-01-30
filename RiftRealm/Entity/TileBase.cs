using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Entity
{
    public abstract class TileBase : IEntity
    {
        bool _indoors;
        bool _obstructive;
        public virtual bool IsIndoors => _indoors;
        public virtual bool IsObstructive => _obstructive;
    }
}
