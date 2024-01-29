using RiftRealm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Map
{
    public interface IWorld
    {
        public WorldResult<Character> MovePlayerUp();
        public WorldResult<Character> MovePlayerDown();
        public WorldResult<Character> MovePlayerLeft();
        public WorldResult<Character> MovePlayerRight();
        public List<List<RiftRealm.Entity.IEntity>> GetWorld<IEntity>();
    }
}
