using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Thieve : MainCharacter
    {
        public Thieve () 
        {
            name = "Thieve";
            damage = 10;
            defence = 0.1f;
            hp = 115;
            sp = 0;
            x = 80f;
            y = 10f;
            lvl = 1;
            gold = 50;
            ix = 2;
            iy = 3;
            specaction = "Украсть";
            if (hp > 0)
            {
                battlesym = 'T';
            }
            else
            {
                battlesym = '+';
                hp = 0;
            }
        }

        public void Steal(List<Enemy> enemy)
        {
            //enemy.little
        }
    }
}
