using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class LittlePoition : Item
    {
        public LittlePoition(string name) : base(name) { }

        public void Heal(List<Item> poitions, MainCharacter hero)
        {
            poitions.RemoveAt(poitions.Count - 1);
            hero.hp += 30;

        }
    }
}
