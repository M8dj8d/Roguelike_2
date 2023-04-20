using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class MiddlePoition : Item
    {
        public MiddlePoition() 
        {
            name = "middlePoition";
        }
        public static void Heal(List<Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.realhp - hero.hp >= 60)
                {
                    MiddlePoition middlePoition = new MiddlePoition();
                    poitions.Remove(middlePoition);
                    hero.hp += 60;
                }
                else
                {
                    hero.hp = hero.realhp;
                }
            }
        }
    }
}
