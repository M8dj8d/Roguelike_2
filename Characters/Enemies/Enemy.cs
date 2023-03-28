using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{

    class Enemy : Character
    {
        public int retgol;              //золото, которое в конце боя получит игрок
        public Enemy(int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, char sym, int retgol) : base(damage, defence, hp, sp, x, y, ix, iy, sym)
        {
            this.retgol = retgol;
        }
    }
}
