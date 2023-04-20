using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class BigPoition : Item
    {
        public BigPoition()
        {
            name = "bigPoition";
        }
        public static void Heal(List<Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.realhp - hero.hp >= 100)
                {
                    BigPoition bigPoition = new BigPoition();
                    poitions.Remove(bigPoition);
                    hero.hp += 100;
                }
                else
                {
                    hero.hp = hero.realhp;
                }
            }
        }
    }
}
