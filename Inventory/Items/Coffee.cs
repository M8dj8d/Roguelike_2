using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class Coffee : Item
    {
        public Coffee()
        {
            name = "coffe";
        }
        public static void Restores_SP(List <Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.realsp - hero.sp >= 30)
                {
                    Coffee coffee = new Coffee();
                    poitions.Remove(coffee);
                    hero.sp += 30;
                }
                else
                {
                    hero.sp = hero.realsp;
                }
            }
        }
    }
}
