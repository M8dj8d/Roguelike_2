using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class Dungeon
    {
        private static Int32 DungeonWidth = 165;
        private static Int32 DungeonHeight = 38;
        private static Int32 DungeonRooms = 15;

        static void Main()
        {
            BlackMage blmage = new BlackMage();
            WhiteMage whmage = new WhiteMage();
            Knight knight = new Knight();
            Thieve thieve = new Thieve();


            //Goblin[] gob = new Goblin[4];


            //gob[0] = new Goblin(10, 0.2f, 100, 0, 10f, 6f, 2, 3, 'G', 10);
            //gob[1] = new Goblin(10, 0.2f, 100, 0, 10f, 10f, 2, 3, 'G', 10);
            //gob[2] = new Goblin(10, 0.2f, 100, 0, 10f, 14f, 2, 3, 'G', 10);
            //gob[3] = new Goblin(10, 0.2f, 100, 0, 10f, 18f, 2, 3, 'G', 10);

            List<Enemy> enemies = new List<Enemy>();

            Random rnd = new Random();

            for (int i = 0; i < 16; i += 4)
            {
                var enemy_type = rnd.Next(1, 10);
                if (enemy_type <= 3)
                {
                    Goblin[] goblins = new Goblin[4];
                    goblins[i / 4] = new Goblin(10, 6 + i);
                    enemies.Add(goblins[i / 4]);
                }
                else if (enemy_type > 6)
                {
                    Slime[] slimes = new Slime[4];
                    slimes[i / 4] = new Slime(10, 6 + i);
                    enemies.Add(slimes[i / 4]);
                }
                else if (enemy_type > 3 && enemy_type <= 6)
                {
                    Zombie[] zombies = new Zombie[4];
                    zombies[i / 4] = new Zombie(10, 6 + i);
                    enemies.Add(zombies[i / 4]);
                }
            }

            List<Item> items = new List<Item>();



            Battlefield.Pole(knight, thieve, blmage, whmage, enemies);


            //Grid map = new Grid(DungeonWidth, DungeonHeight, DungeonRooms);

            //if (map.GenerateRooms().Equals(false))
            //{
            //    Console.WriteLine("Error: failed to generate dungeon map rooms.");
            //    return 1;
            //}

            //else if (map.GenerateTunnels().Equals(false))
            //{
            //    Console.WriteLine("Error: failed to generate dungeon map tunnels.");
            //    return 1;
            //}

            //else if (map.Print().Equals(false))
            //{
            //    Console.WriteLine("Error: failed to print a dungeon map.");
            //    return 2;
            //}

            //Console.WriteLine("Successfully generated a dungeon map.");
            //return 0;

        }



        //static void Movement(CallInfo[,] myArray)
        //{
        //    short x = 1;
        //    short y = 1;
        //    ConsoleKeyInfo consoleKey = Console.ReadKey();
        //    short temp_x = x;
        //    short temp_y = y;
        //    switch (consoleKey.Key)
        //    {
        //        case ConsoleKey.W:
        //            --temp_y;
        //            break;

        //        case ConsoleKey.A:
        //            --temp_x;
        //            break;

        //        case ConsoleKey.S:
        //            --temp_y;
        //            break;

        //        case ConsoleKey.D:
        //            --temp_x;
        //            break;
        //    }
        //    if (myArray[temp_y, temp_x].cellID != CellID.Wall)
        //    {
        //        myArray[y, x].cellID = CellID.None;
        //        y = temp_y;
        //        x = temp_x;
        //        myArray[y, x].cellID = CellID.Player;
        //    }
        //}

    }
}