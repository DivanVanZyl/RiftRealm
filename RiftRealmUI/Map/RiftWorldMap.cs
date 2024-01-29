using RiftRealm.Entity;
using RiftRealm.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealmUI.Map
{
    public class RiftWorldMap : IMapUI
    {
        private List<List<char>> _map;
        private int _height;
        private int _width;

        public RiftWorldMap(int height, int width)
        {
            _map = new List<List<char>>();
            foreach (int i in Enumerable.Range(0, width))
            {
                _map.Add(new List<char>());
                for (int j = 0; j < height; j++)
                {
                    _map[i].Add('.');
                }
            }
            _width = width;
            _height = height;
        }

        public RiftWorldMap(IWorld world) 
        {
            _map = new List<List<char>>();
            var thisMap = world.GetWorld<IEntity>();
            _height = thisMap[0].Count;
            _width = thisMap.Count;

            for (int i = 0;i < _width; i++)
            {
                _map.Add(new List<char>());
                for (int j = 0; j < _height; j++)
                {
                    var currentElementType = thisMap[i][j].GetType();
                    var currentElement = thisMap[i][j];
                    if (currentElementType == typeof(Character))
                    {
                        _map[i].Add('@');
                    }
                    else if (currentElementType == typeof(FloorTile))
                    {
                        if (currentElement.IsIndoors)
                        {
                            _map[i].Add('.');
                        }
                        else
                        {
                            _map[i].Add('*');
                        }
                    }
                    else
                    {
                        _map[i].Add('?');
                    }
                }
            }
        }

        public List<List<char>> GetMap()
        {
            return _map;
        }

        public int GetMapHeight()
        {
            return _map.Count;
        }

        public int GetMapWidth()
        {
            return _map[0].Count;
        }
    }
}
