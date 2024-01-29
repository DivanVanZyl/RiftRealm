// See https://aka.ms/new-console-template for more information\
using RiftRealm.Map;
using RiftRealm.UI;
using RiftRealmUI;
using RiftRealmUI.Map;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Welcome to Rift Realm.");

IGui gui = new ConsoleGui();
IWorld world =new RiftRealmWorld();

while (true)
{
    gui.DisplayMap(new RiftWorldMap(world));

    var key = Console.ReadKey();
    if(key.Key == ConsoleKey.W)
    {
        world.MovePlayerUp();
    }
    else if (key.Key == ConsoleKey.S)
    {
        world.MovePlayerDown();
    }
    else if (key.Key == ConsoleKey.D)
    {
        world.MovePlayerRight();
    }
    else if (key.Key == ConsoleKey.A)
    {
        world.MovePlayerLeft();
    }
    else if(key.Key == ConsoleKey.Escape)
    {
        break;
    }
    Console.Clear();
}


