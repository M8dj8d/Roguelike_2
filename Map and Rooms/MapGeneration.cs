using RogueSharp.DiceNotation;
using RogueSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class MapGeneration
    {
        //private readonly int width;             //длина комнаты
        //private readonly int height;            //высота комнаты    
        //private readonly int maxRooms;          //максимальное количество комнат
        //private readonly int max_room_size;     //максимальный размер комнаты
        //private readonly int min_room_size;     //минимальный размер комнаты
        //private readonly int level_map;

        //private readonly MapD map;

        //public MapGeneration(int width, int height, int maxRooms, int max_room_size, int min_room_size, int level_map)
        //{
        //    this.width = width;
        //    this.height = height;
        //    this.maxRooms = maxRooms;
        //    this.max_room_size = max_room_size;
        //    this.min_room_size = min_room_size;
        //    this.level_map = level_map;
        //    map = new MapD();
        //}

        //private void StairsCreator()
        //{
        //    map.StairsUp = new Stairs
        //    {
        //        X = map.Rooms.First().Center.X + 1,
        //        Y = map.Rooms.First().Center.Y,
        //        IsUp = true
        //    };

        //    map.StairsDown = new Stairs
        //    {
        //        X = map.Rooms.Last().Center.X,
        //        Y = map.Rooms.Last().Center.Y,
        //        IsUp = false
        //    };
        //}

        //public MapD MapInit()
        //{
        //    map.Initialize(width, height);
        //    Random rnd = new Random();

        //    for (int r = maxRooms; r > 0; r--)
        //    {
        //        int room_width = (int)rnd.Next(min_room_size, max_room_size);
        //        int room_height = (int)rnd.Next(min_room_size, max_room_size);
        //        int room_abciss = (int)rnd.Next(1, width - room_width - 1);
        //        int room_ordinate = (int)rnd.Next(1, width - room_height - 1);

        //        var newRoom = new Rectangle(room_abciss, room_ordinate, room_width, room_height);

        //        bool newRoomIntersects = map.Rooms.Any(room => newRoom.Intersects(room));

        //        if (!newRoomIntersects)
        //        {
        //            map.Rooms.Add(newRoom);
        //        }
        //    }
        //    foreach (Rectangle room in map.Rooms)
        //    {
        //        CreateRoom(room);
        //    }

        //    for (int r = 1; r < map.Rooms.Count; r++)
        //    {
        //        int previous_room_center_abciss = map.Rooms[r - 1].Center.X;
        //        int previous_room_center_ordinate = map.Rooms[r - 1].Center.Y;
        //        int current_room_center_abciss = map.Rooms[r].Center.X;
        //        int current_room_center_ordiate = map.Rooms[r].Center.Y;

        //        if (rnd.Next(1, 2) == 1)
        //        {
        //            Create_Horizontal_Corridor(previous_room_center_abciss, current_room_center_abciss, previous_room_center_ordinate);
        //            Create_Vertical_Corrdidor(previous_room_center_ordinate, current_room_center_ordiate, current_room_center_abciss);
        //        }
        //        else
        //        {
        //            Create_Vertical_Corrdidor(previous_room_center_ordinate, current_room_center_ordiate, current_room_center_abciss);
        //            Create_Horizontal_Corridor(previous_room_center_abciss, current_room_center_abciss, current_room_center_ordiate);
        //        }
        //    }

        //    foreach (Rectangle room in map.Rooms)
        //    {
        //        CreateRoom(room);
        //        CreateDoors(room);
        //    }

        //    StairsCreator();

        //    //PlacePlayer();

        //    PlaceMonsters();

        //    return map;
        //}

        //// Chooses a place to place the player on the map
        //// Change later so monsters don't spawn in spawn room? or at least not on first level?
        ////private void PlacePlayer()
        ////{
        ////    //Player player = Game.Player;
        ////    if (player == null)
        ////    {
        ////        player = new Player();
        ////    }

        ////    player.X = map.Rooms[0].Center.X;
        ////    player.Y = map.Rooms[0].Center.Y;

        ////    map.AddPlayer(player);
        ////}


        //// Creates a rectangular dungeon room
        //private void CreateRoom(Rectangle room)
        //{
        //    for (int x = room.Left + 1; x < room.Right; x++)
        //    {
        //        for (int y = room.Top + 1; y < room.Bottom; y++)
        //        {
        //            map.SetCellProperties(x, y, true, true, false);
        //        }
        //    }
        //}

        //private void Create_Horizontal_Corridor(int xStart, int xEnd, int yPosition)
        //{
        //    for (int x = Math.Min(xStart, xEnd); x <= Math.Max(xStart, xEnd); x++)
        //    {
        //        map.SetCellProperties(x, yPosition, true, true);
        //    }
        //}

        //private void Create_Vertical_Corrdidor(int yStart, int yEnd, int xPosition)
        //{
        //    for (int y = Math.Min(yStart, yEnd); y <= Math.Max(yStart, yEnd); y++)
        //    {
        //        map.SetCellProperties(xPosition, y, true, true);
        //    }
        //}

        //private void PlaceMonsters()
        //{
        //    Random rnd = new Random();
        //    foreach (var room in map.Rooms)
        //    {
        //        if (rnd.Next(1, 10) < 7)
        //        {
        //            Point room_location = map.GetRandomWalkableLocationInRoom(room);
        //            if (room_location != null)
        //            {
        //                List<Enemy> enemies = new List<Enemy>();
                            
        //                for (int i = 0; i < 16; i += 4)
        //                {
        //                    var enemy_type = rnd.Next(1, 10);
        //                    if (enemy_type <= 3)
        //                    {
        //                        Goblin[] goblins = new Goblin[4];
        //                        goblins[i / 4] = new Goblin(10, 6 + i);
        //                        enemies.Add(goblins[i / 4]);
        //                    }
        //                    else if (enemy_type > 6)
        //                    {
        //                        Slime[] slimes = new Slime[4];
        //                        slimes[i / 4] = new Slime(10, 6 + i);
        //                        enemies.Add(slimes[i / 4]);
        //                    }
        //                    else if (enemy_type > 3 && enemy_type <= 6)
        //                    {
        //                        Zombie[] zombies = new Zombie[4];
        //                        zombies[i / 4] = new Zombie(10, 6 + i);
        //                        enemies.Add(zombies[i / 4]);
        //                    } 
        //                }

        //                //enemies.mx = room_location.X;
        //                //enemies.my = room_location.Y;
        //                map.AddMonster(enemies);
        //            }
                    
        //        }
        //    }
        //}

        //// Create the doors for each room
        //private void CreateDoors(Rectangle room)
        //{
        //    // The the boundries of the room
        //    int xMin = room.Left;
        //    int xMax = room.Right;
        //    int yMin = room.Top;
        //    int yMax = room.Bottom;

        //    // Put the rooms border cells into a list
        //    List<ICell> borderCells = map.GetCellsAlongLine(xMin, yMin, xMax, yMin).ToList();
        //    borderCells.AddRange(map.GetCellsAlongLine(xMin, yMin, xMin, yMax));
        //    borderCells.AddRange(map.GetCellsAlongLine(xMin, yMax, xMax, yMax));
        //    borderCells.AddRange(map.GetCellsAlongLine(xMax, yMin, xMax, yMax));

        //    // Go through each of the rooms border cells and look for locations to place doors.
        //    foreach (Cell cell in borderCells)
        //    {
        //        //if (IsPotentialDoor(cell))
        //        //{
        //        //    // A door must block field-of-view when it is closed.
        //        //    map.SetCellProperties(cell.X, cell.Y, false, true);
        //        //    map.Doors.Add(new Door
        //        //    {
        //        //        X = cell.X,
        //        //        Y = cell.Y,
        //        //        IsOpen = false
        //        //    });
        //        //}
        //    }
        //}

        //// Checks to see if a cell is a good candidate for placement of a door
        ////private bool IsPotentialDoor(Cell cell)
        ////{
        //    // If the cell is not walkable
        //    // then it is a wall and not a good place for a door
        //    //if (!cell.IsWalkable)
        //    //{
        //    //    return false;
        //    //}

        //    // Store references to all of the neighboring cells 
        //    //Cell right = map.GetCell(cell.X + 1, cell.Y);
        //    //Cell left = map.GetCell(cell.X - 1, cell.Y);
        //    //Cell top = map.GetCell(cell.X, cell.Y - 1);
        //    //Cell bottom = map.GetCell(cell.X, cell.Y + 1);

        //    // Make sure there is not already a door here
        //    //if (map.GetDoor(cell.X, cell.Y) != null ||
        //    //    map.GetDoor(right.X, right.Y) != null ||
        //    //    map.GetDoor(left.X, left.Y) != null ||
        //    //    map.GetDoor(top.X, top.Y) != null ||
        //    //    map.GetDoor(bottom.X, bottom.Y) != null)
        //    //{
        //    //    return false;
        //    //}

        //    //if (right.IsWalkable && left.IsWalkable && !top.IsWalkable && !bottom.IsWalkable)
        //    //{
        //    //    return true;
        //    //}

        //    //if (!right.IsWalkable && !left.IsWalkable && top.IsWalkable && bottom.IsWalkable)
        //    //{
        //    //    return true;
        //    //}
        //    //return false;
        ////}


    }
}
