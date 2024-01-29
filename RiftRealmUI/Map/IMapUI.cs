using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealmUI.Map
{
    internal interface IMapUI
    {
        public List<List<char>> GetMap();
        public int GetMapHeight();
        public int GetMapWidth();
    }
}
