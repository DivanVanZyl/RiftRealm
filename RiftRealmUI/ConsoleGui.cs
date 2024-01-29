using RiftRealm.UI;
using RiftRealmUI.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealmUI
{
    internal class ConsoleGui : IGui
    {
        public void DisplayMap(IMapUI map)
        {
            List<List<char>> mapData = map.GetMap();
            int mapHeight = map.GetMapHeight();
            int mapWidth = map.GetMapWidth();
            for (int i = 0;i < mapHeight;i++)
            {
                for (int j = 0;j < mapWidth;j++)
                {
                    Console.Write(mapData[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
