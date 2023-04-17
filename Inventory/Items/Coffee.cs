using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Coffee : Item
    {
        public static void Restores_SP(List <Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.realhp - hero.hp >= 30)
                {
                    Coffee coffee = new Coffee();
                    poitions.Remove(coffee);
                    hero.hp += 30;
                }
                else
                {
                    hero.hp = hero.realhp;
                }
            }
        }
    }
}
