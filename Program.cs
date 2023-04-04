using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Program
    {
        static void Main()
        {
            BlackMage blmage = new BlackMage("Антон", 10, 0.1f, 100, 100, 80f, 14f, 1, 3, 1, 50, "Заклинание", 'M');
            WhiteMage whmage = new WhiteMage("Толик", 10, 0.1f, 10, 100, 80f, 18f, 1, 3, 1, 50, "Заклинание", 'W');
            Knight knight = new Knight("Борис", 20, 0.3f, 100, 0, 79f, 6f, 3, 3, 1, 50, "Концентрация", 'K');
            Thieve thieve = new Thieve("Игорь", 15, 0.2f, 10, 0, 80f, 10f, 2, 3, 1, 50, "Украсть", 'T');


            Goblin[] gob = new Goblin[4];


            gob[0] = new Goblin(10, 0.2f, 100, 0, 10f, 6f, 2, 3, 'G', 10);
            gob[1] = new Goblin(10, 0.2f, 100, 0, 10f, 10f, 2, 3, 'G', 10);
            gob[2] = new Goblin(10, 0.2f, 100, 0, 10f, 14f, 2, 3, 'G', 10);
            gob[3] = new Goblin(10, 0.2f, 100, 0, 10f, 18f, 2, 3, 'G', 10);

            List<Item> items = new List<Item>();

            Battlefield.Pole(knight, thieve, blmage, whmage, gob);




        }



        //static void Movement(CellInfo[,] myArray)
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
    

