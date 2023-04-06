using RLNET;
using RogueSharp;

namespace Roguelike_2
{
    class Door
    {   
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Door()
        {
            Symbol = '+';
        }
        public bool IsOpen { get; set; }

        

        public void Draw(RLConsole console, IMap map)
        {
            if (!map.GetCell(X, Y).IsExplored)
            {
                return;
            }

            Symbol = IsOpen ? '-' : '+';

            console.Set(X, Y, null, null, Symbol);
        }


    }
}
