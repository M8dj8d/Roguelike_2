﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class Goblin : Enemy
    {
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
            LittlePoition littlePoition = new LittlePoition();
            Coffee coffee = new Coffee();
            this.poitions.Add(littlePoition);
            this.poitions.Add(coffee);
        }
    }
}
