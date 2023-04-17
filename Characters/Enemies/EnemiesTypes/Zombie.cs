using RogueSharp.DiceNotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Roguelike_2
{
    class Zombie : Enemy
    {
        public Zombie(float x, float y)
        {
            damage = 40;
            defence = 0.1f;
            hp = 90;
            sp = 0;
            base.x = x;
            base.y = y;
            ix = 4;
            iy = 3;
            battlesym = 'Z';
            retgol = 150;
            BigPoition bigPoition = new BigPoition();
            PhoenixDown phoenixDown = new PhoenixDown();
            this.poitions.Add(bigPoition);
            this.poitions.Add(phoenixDown);
        }
    }
}
