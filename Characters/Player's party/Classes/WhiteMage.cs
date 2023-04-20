using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    public class WhiteMage : MainCharacter, IWhiteMagic
    {
        public WhiteMage()
        {
            name = "Ann";
            damage = 25;
            defence = 0.1f;
            hp = 100;
            realhp = hp;
            sp = 100;
            realsp = sp;
            x = 80f;
            y = 18f;
            lvl = 1;
            gold = 50;
            ix = 1;
            iy = 3;
            specaction = "Заклинание";
            if (hp > 0)
            {
                battlesym = 'W';
            }
            else
            {
                battlesym = '+';
                hp = 0;
            }
        }

        public void Dia(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 8 && ally.hp != 0)
            {
                if (ally.realhp - ally.hp >= 50)
                {
                    ally.hp += 50;
                    wmage.sp -= 8;  
                }
                else
                {
                    ally.hp = ally.realhp;
                    wmage.sp -= 8;
                }
            }
            else
            {
                Console.SetCursorPosition(10, 35);
                Console.WriteLine("У вас не получается восстановить здоровье");
            }
        }

        public void Diarahan(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 12 && ally.hp != 0)
            {
                if (ally.realhp - ally.hp > 70)
                {
                    ally.hp += 70;
                    wmage.sp -= 12;
                }
                else
                {
                    ally.hp = ally.realhp;
                    wmage.sp -= 12;
                }
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас не получается восстановить здоровье");
            }
        }

        public void Diarama(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 20 && ally.hp != 0)
            {
                if (ally.realhp - ally.hp > 100)
                {
                    ally.hp += 100;
                    wmage.sp -= 20;
                }
                else
                {
                    ally.hp = ally.realhp;
                    wmage.sp -= 20;
                }
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас не получается восстановить здоровье");
            }
        }

        public void Recarm(WhiteMage wmage, MainCharacter ally)
        {
            if (wmage.sp >= 20 && ally.hp == 0)
            {
                ally.hp += 20;
                wmage.sp -= 20;
            }
            else
            {
                Console.SetCursorPosition(20, 33);
                Console.WriteLine("У вас не получается восстановить здоровье");
            }
        }
    }
}
