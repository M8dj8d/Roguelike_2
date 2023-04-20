using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class Slime : Enemy
    {

        //public LittlePoition[] littlePoitions = new LittlePoition[2];

        public Slime(float x, float y)
        {
            damage = 30;
            defence = 0.4f;
            hp = 115;
            sp = 0;
            base.x = x;
            base.y = y;
            ix = 3;
            iy = 2;
            battlesym = 'S';
            retgol = 100;
            MiddlePoition middlePoition = new MiddlePoition();
            Coffee coffee = new Coffee();
            this.poitions.Add(middlePoition);
            this.poitions.Add(coffee);
        }
    }
}
