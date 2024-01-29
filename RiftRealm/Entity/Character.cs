using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Entity
{
    public class Character : TileBase
    {
        public string Name { get; set; }
        public IEntity UnderFoot { get; set; } //The tile type inder the foot of the character.

        public Character(string name, IEntity underFoot)
        {
            Name = name;
            UnderFoot = underFoot;
        }
    }
}
