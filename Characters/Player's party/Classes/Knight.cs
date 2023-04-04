using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Knight : MainCharacter
    {
        public Knight (string name, int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, int lvl,  int gold, string specaction, char sym) : base (name, damage, defence, hp, sp, x, y, ix, iy, lvl, gold, specaction, sym) { }

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
