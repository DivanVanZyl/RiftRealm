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

        public bool IsIndoors => _indoors;
    }
}
