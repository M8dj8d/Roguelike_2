using System;

namespace Prot
{
    class Program
    {
        short x = 1;
        short y = 1;
        public void Movement(CellInfo[,] myArray)
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            short temp_x = x;
            short temp_y = y;
            switch (consoleKey.Key)
            {
                case ConsoleKey.W:
                    --temp_y;
                    break;

                case ConsoleKey.A:
                    --temp_x;
                    break;

                case ConsoleKey.S:
                    --temp_y;
                    break;

                case ConsoleKey.D:
                    --temp_x;
                    break;
            }
            if (myArray[temp_y, temp_x].cellID != CellID.Wall)
            {
                myArray[y, x].cellID = CellID.None;
                y = temp_y;
                x = temp_x;
                myArray[y, x].cellID = CellID.Player;
            }
        }
    }
}