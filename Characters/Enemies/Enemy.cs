using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{

    public class Enemy : Character
    {
        public int retgol;              //золото, которое в конце боя получит игрок
        public char sym;

        public List<Item> poitions = new List<Item>();


        public void Attak(Enemy goblin, MainCharacter hero)
        {
            Enemy_Attak_Animation(goblin);
            hero.hp -= (int)Math.Round((float)goblin.damage * (1f - hero.defence));
            Battlefield.Helping(10, 25, hero.name + " получает " + Math.Round((float)goblin.damage * (1f - hero.defence)) + " урона");
            Thread.Sleep(500);
        }

        private static void Enemy_Attak_Animation(Enemy enemy)
        {
            Battlefield.Helping(Convert.ToInt32(enemy.x) + 9, Convert.ToInt32(enemy.y + 1), "-");
            Thread.Sleep(250);
            Battlefield.Helping(Convert.ToInt32(enemy.x) + 10, Convert.ToInt32(enemy.y + 1), "-");
            Thread.Sleep(250);
            Battlefield.Helping(Convert.ToInt32(enemy.x) + 11, Convert.ToInt32(enemy.y + 1), "-");
            Thread.Sleep(250);
        }
    }
}
