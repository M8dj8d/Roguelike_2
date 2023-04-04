using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{

    class Enemy : Character
    {
        public int retgol;              //золото, которое в конце боя получит игрок
        public Enemy(int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, char sym, int retgol) : base(damage, defence, hp, sp, x, y, ix, iy, sym)
        {
            this.retgol = retgol;
        }

        public void Attak(Enemy goblin, MainCharacter hero)
        {
            Enemy_Attak_Animation(goblin);
            hero.hp -= (int)Math.Round((float)goblin.damage * (1f - hero.defence));
            Battlefield.Helping(10, 25, hero.name + " получает " + Math.Round((float)goblin.damage * (1f - hero.defence)) + " урона");
        }

        private static void Enemy_Attak_Animation(Enemy enemy)
        {
            Console.SetCursorPosition(Convert.ToInt32(enemy.x) + 7, Convert.ToInt32(enemy.y + 1));
            Thread.Sleep(250);
            Console.Write("-");
            Console.SetCursorPosition(Convert.ToInt32(enemy.x) + 8, Convert.ToInt32(enemy.y + 1));
            Thread.Sleep(250);
            Console.Write("-");
            Console.SetCursorPosition(Convert.ToInt32(enemy.x) + 9, Convert.ToInt32(enemy.y + 1));
            Thread.Sleep(250);
            Console.Write("-");
        }
    }
}
