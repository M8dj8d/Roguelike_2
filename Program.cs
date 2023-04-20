using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Roguelike_2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            BlackMage blmage = new BlackMage();
            WhiteMage whmage = new WhiteMage();
            Knight knight = new Knight();
            Thieve thieve = new Thieve();

            for (int i = 0; i < 5; i++)
            {
                LittlePoition littlePoition = new LittlePoition();  
                MainCharacter.inventory.items.Add(littlePoition);
            }
            
            for(int i = 0; i < 3; i++)
            {
                MiddlePoition middlePoition = new MiddlePoition();
                MainCharacter.inventory.items.Add(middlePoition);
            }

            BigPoition bigPoition = new BigPoition();
            MainCharacter.inventory.items.Add(bigPoition);

            Coffee coffee = new Coffee();
            MainCharacter.inventory.items.Add(coffee);

            for (int i = 0; i < 3; i++)
            {
                PhoenixDown phoenixDown = new PhoenixDown();
                MainCharacter.inventory.items.Add(phoenixDown);
            }

            if (args.Length == 1)
            {
                StartFight(args[0], blmage, whmage, knight, thieve);
            }
            else
            {
                OpenFightWindow();
            }



            //Battlefield.Pole(knight, thieve, blmage, whmage, enemies);
        }

        public static void StartFight(string filename, BlackMage blmage, WhiteMage whmage, Knight knight, Thieve thieve)
        {
            Console.WindowWidth = 170;
            Console.WindowHeight = 40;
            Console.Title = "Battle mode";

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

            Battlefield.Pole(knight, thieve, blmage, whmage, enemies);

            using (var mmf = MemoryMappedFile.OpenExisting(filename))
            using (var stream = mmf.CreateViewStream())
            {
                var bw = new BinaryWriter(stream);
            }
        }

        public static void OpenFightWindow()
        {
            Console.Title = "Dungeon";

            var randomFileName = Guid.NewGuid().ToString();

            using (var mmf = MemoryMappedFile.CreateNew(randomFileName, 1))
            {
                var proc = Process.Start(Assembly.GetExecutingAssembly().Location, randomFileName);
                proc.WaitForExit();

                using (var stream = mmf.CreateViewStream())
                {
                    var reader = new BinaryReader(stream);
                    var key = reader.ReadChar();

                }
            }
        }
    }
}