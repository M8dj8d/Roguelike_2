using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Goblin : Enemy
    {
        public LittlePoition[] littlePoitions = new LittlePoition[2];
        public Goblin(float x, float y)
        {
            damage = 25;
            defence = 0.2f;
            hp = 100;
            sp = 0;
            base.x = x;
            base.y = y;
            ix = 3;
            iy = 3;
            battlesym = 'G';
            retgol = 50;
        }
    }
}
