using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Knight : MainCharacter
    {
        public Knight () 
        {
            name = "Knight";
            damage = 20;
            defence = 0.3f;
            hp = 150;
            sp = 0;
            x = 80f;
            y = 6f;
            lvl = 1;
            gold = 50;
            ix = 3;
            iy = 3;
            specaction = "Концентрация";
            if (hp > 0)
            {
                battlesym = 'K';
            }
            else
            {
                battlesym = '+';
                hp = 0;
            }
        }

        public void Concentrate(Knight knight)
        {
            knight.damage *= 2;
            knight.defence *= 2;
        }

        public void Return(Knight knight)
        {
            knight.damage /= 2;
            knight.defence /= 2;
        }
    }
}
