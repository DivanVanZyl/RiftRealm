using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Entity
{
    public class Wall : TileBase
    {
        public new bool IsObstructive => true;
    }
}
