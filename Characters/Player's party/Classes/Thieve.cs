using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Thieve : MainCharacter
    {
        public Thieve () : base()
        {
            name = "Thieve";
            damage = 10;
            defence = 0.1f;
            hp = 115;
            sp = 0;
            realhp = hp;
            x = 80f;
            y = 10f;
            lvl = 1;
            gold = 50;
            ix = 2;
            iy = 3;
            specaction = "Украсть";
        }

        public void Steal(List<Enemy> enemy)
        {
            Battlefield.Helping(10, 25, "Введите номер противника, которого вы хотите ограбить: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < enemy.Count && number >= 0)
            {
                Random rnd = new Random();
                byte a = (byte)rnd.Next(1, 10);
                if (enemy[number - 1].poitions.Count > 0 && a > 5)
                {
                    Random rand = new Random();
                    int poitionNumber = rand.Next(enemy[number - 1].poitions.Count);

                    Item item = enemy[number - 1].poitions[poitionNumber];
                    enemy[number - 1].poitions.RemoveAt(poitionNumber);

                    inventory.items.Add(item);
                }
                else
                {
                    Battlefield.Helping(10, 26, "У вас ничего не вышло");
                    Thread.Sleep(400);
                }
            }
        }
    }
}
