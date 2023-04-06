using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using RLNET;
using RogueSharp;

namespace Roguelike_2
{
    public class Stairs
    {
        public char Symbol
        {
            get; set;
        }
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        public bool IsUp
        {
            get; set;
        }

        public void Draw(RLConsole console, IMap map)
        {
            if (!map.GetCell(X, Y).IsExplored)
            {
                return;
            }

            

            console.Set(X, Y, null, null, Symbol);
        }
    }
}