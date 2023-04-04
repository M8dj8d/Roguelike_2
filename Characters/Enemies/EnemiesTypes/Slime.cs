using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Slime : Enemy
    {
        public Slime(int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, char sym, int retgol) : base(damage, defence, hp, sp, x, y, ix, iy, sym, retgol)
        {

        }
    }
}
