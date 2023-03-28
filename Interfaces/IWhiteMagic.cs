using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    interface IWhiteMagic
    {
        void Dia(WhiteMage wmage, MainCharacter ally);
        void Diarama(WhiteMage wmage, MainCharacter ally);
        void Diarahan(WhiteMage wmage, MainCharacter ally);
    }
}
