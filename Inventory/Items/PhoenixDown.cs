using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class PhoenixDown : Item
    {
        public PhoenixDown() 
        {
            name = "phoenixDown";
        }
        public static void Resurrection(List <Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.hp == 0)
                {
                    PhoenixDown phoenixDown = new PhoenixDown();
                    poitions.Remove(phoenixDown);
                    hero.hp = 20;
                }
                else
                {
                    Battlefield.Helping(10, 32, "Не сработало");
                    Thread.Sleep(400);
                }
            }
        }
    }
}
