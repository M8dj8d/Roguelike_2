using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class WhiteMage : MainCharacter, IWhiteMagic
    {
        public WhiteMage (string name, int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, int lvl, int gold, string specaction, char sym) : base(name, damage, defence, hp, sp, x, y, ix, iy, lvl, gold, specaction, sym) { }

        public void Dia(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 8)
            {
                ally.hp += 50;
                wmage.sp -= 8; 
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас недостаточно маны!");
            }
        }

        public void Diarahan(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 12)
            {
                ally.hp += 70;
                wmage.sp -= 12; 
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас недостаточно маны!");
            }
        }

        public void Diarama(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 20)
            {
                ally.hp += 100;
                wmage.sp -= 20; 
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас недостаточно маны!");
            }
        }
    }
}
