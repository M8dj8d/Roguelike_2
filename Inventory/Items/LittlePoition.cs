using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class LittlePoition : Item
    {
        public LittlePoition(string name, int amount) : base(name, amount) { }

        public void Heal(List<Item> poitions, MainCharacter hero)
        {
            poitions.RemoveAt(poitions.Count - 1);
            hero.hp += 30;

        }
    }
}
