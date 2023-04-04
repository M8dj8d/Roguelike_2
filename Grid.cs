using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Grid
    {
        private static readonly Random Generator = new Random();
        private static readonly Int32 MinimumRoomSize = 4, MaximumRoomSize = 7, Spacing = 3;
        private static readonly Char OpenedSpace = 'X', TunnelSpace = '+', ClosedSpace = '~';

        private List<Rectangle> Rooms;
        private Char[,] Tiles;
        private Int32 Width, Height, Count;

        public Grid(Int32 width, Int32 height, Int32 count)
        {
            Rooms = new List<Rectangle>();
            Tiles = new Char[width, height];
            Width = width;
            Height = height;
            Count = count;

            for (Int32 x = 0; x < Width; ++x)
                for (Int32 y = 0; y < Height; ++y)
                    Tiles[x, y] = ClosedSpace;
        }

        public Boolean Print()
        {
            if (Width <= 0 || Height <= 0 || Count <= 0)
                return false;

            for (Int32 y = 0; y < Height; ++y)
            {
                for (Int32 x = 0; x < Width; ++x)
                    Console.Write(Tiles[x, y]);

                Console.WriteLine();
            }

            return true;
        }

        public Boolean GenerateRooms()
        {
            Rectangle room = new Rectangle(), temp = new Rectangle();
            Int32 tries = 0;
            Boolean valid;

            if (Width <= 0 || Height <= 0 || Count <= 0)
                return false;

            while (Rooms.Count < Count && tries < (1 << 20))
            {
                room.X = Generator.Next(0, Width - MaximumRoomSize + 1);
                room.Y = Generator.Next(0, Height - MaximumRoomSize + 1);
                room.Width = Generator.Next(MinimumRoomSize, MaximumRoomSize + 1);
                room.Height = Generator.Next(MinimumRoomSize, MaximumRoomSize + 1);
                valid = true;

                foreach (Rectangle rectangle in Rooms)
                {
                    temp.X = rectangle.X - Spacing;
                    temp.Y = rectangle.Y - Spacing;
                    temp.Width = rectangle.Width + Spacing * 2;
                    temp.Height = rectangle.Height + Spacing * 2;

                    if (room.IntersectsWith(temp).Equals(true))
                    {
                        ++tries;
                        valid = false;

                        break;
                    }
                }

                if (valid.Equals(true))
                    Rooms.Add(room);
            }

            for (Int32 x = 0; x < Width; ++x)
                for (Int32 y = 0; y < Height; ++y)
                    foreach (Rectangle rectangle in Rooms)
                        if (rectangle.IntersectsWith(new Rectangle(x, y, 1, 1)).Equals(true))
                            Tiles[x, y] = OpenedSpace;

            return true;
        }

        public Boolean GenerateTunnels()
        {
            if (Width <= 0 || Height <= 0 || Count <= 0)
                return false;

            //?????

            return true;
        }
    }
}
