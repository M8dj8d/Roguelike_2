using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class MainCharacter : Character
    {
        public int lvl;
        public int gold;
        public string specaction;
        public int realhp;
        public string name;

        public MainCharacter(string name, int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, int lvl, int gold, string specaction, char sym) : base (damage,  defence,  hp,  sp,  x,  y,  ix,  iy, sym)
        {
            this.name = name;
            this.lvl = lvl;
            this.gold = gold;
            this.specaction = specaction;
            this.realhp = hp;
        }

    }
}
