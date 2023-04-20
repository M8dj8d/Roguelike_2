using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class LittlePoition : Item
    {
        public LittlePoition()
        {
            name = "littlePoition";
        }
        public static void Heal(List<Item> poitions, MainCharacter hero)
        {
            if (poitions.Count >= 1)
            {
                if (hero.realhp - hero.hp >= 30)
                {
                    LittlePoition littlePoition = new LittlePoition();
                    poitions.Remove(littlePoition);
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
