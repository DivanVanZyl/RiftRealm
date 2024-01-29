using RiftRealm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Map
{
    public class RiftRealmWorld : IWorld
    {
        private List<List<IEntity>> _map;
        private int[] playerCoordinates = new int[2];   //X and Y coordinates

        #region movement
        public WorldResult<Character> MovePlayerUp()
        {
            var c = (Character)_map[playerCoordinates[0]][playerCoordinates[1]];
            if (playerCoordinates[0] > 0)
            {
                _map[playerCoordinates[0]-1][playerCoordinates[1]] = c;
                _map[playerCoordinates[0]][playerCoordinates[1]] = c.UnderFoot;

                playerCoordinates[0]--;

                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "has moved up.";
                return result;
            }
            else
            {
                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "Is already on top.";
                return result;
            }
        }

        public WorldResult<Character> MovePlayerDown()
        {
            var c = (Character)_map[playerCoordinates[0]][playerCoordinates[1]];
            if (playerCoordinates[0] < _map.Count-1)
            {
                _map[playerCoordinates[0] + 1][playerCoordinates[1]] = c;
                _map[playerCoordinates[0]][playerCoordinates[1]] = c.UnderFoot;

                playerCoordinates[0]++;

                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "has moved up.";
                return result;
            }
            else
            {
                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "Is already on top.";
                return result;
            }
        }

        public WorldResult<Character> MovePlayerRight()
        {
            var c = (Character)_map[playerCoordinates[0]][playerCoordinates[1]];
            if (playerCoordinates[1] < _map[0].Count-1)
            {
                _map[playerCoordinates[0]][playerCoordinates[1] + 1] = c;
                _map[playerCoordinates[0]][playerCoordinates[1]] = c.UnderFoot;

                playerCoordinates[1]++;

                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "has moved up.";
                return result;
            }
            else
            {
                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "Is already on top.";
                return result;
            }
        }

        public WorldResult<Character> MovePlayerLeft()
        {
            var c = (Character)_map[playerCoordinates[0]][playerCoordinates[1]];
            if (playerCoordinates[1] > 0)
            {
                _map[playerCoordinates[0]][playerCoordinates[1]-1] = c;
                _map[playerCoordinates[0]][playerCoordinates[1]] = c.UnderFoot;

                playerCoordinates[1]--;

                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "has moved up.";
                return result;
            }
            else
            {
                var result = new WorldResult<Character>();
                result.Data = c;
                result.Success = true;
                result.Message = c.Name + "Is already on top.";
                return result;
            }
        }

        #endregion movement
        public RiftRealmWorld()
        {
            playerCoordinates = new int[2] { 2, 2 };
            _map = new List<List<IEntity>>
            {
                new List<IEntity>() { new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile() },
                new List<IEntity>() { new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile() },
                new List<IEntity>() { new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile() },
                new List<IEntity>() { new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile() },
                new List<IEntity>() { new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile(), new FloorTile() }
            };

            _map[playerCoordinates[0]][playerCoordinates[1]] = new Character("Divan", _map[playerCoordinates[0]][playerCoordinates[1]]);
        }
        public List<List<RiftRealm.Entity.IEntity>> GetWorld<IEntity>()
        {
            return _map;
        }
    }
}
