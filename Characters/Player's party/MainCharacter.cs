using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class MainCharacter : Character
    {
        public int lvl;
        public int gold;
        public string specaction;
        public int realhp;
        public string name;

        public static Inventory inventory = new Inventory();

        public MainCharacter() 
        {
        }

        public void Attak(MainCharacter hero, ref List<Enemy> enemy, byte hit)       //воспроизводит анимацию атаки и саму атаку
        {
            byte which_enemy;
            Battlefield.Helping(100, 24, "Введите номер противника, которого вы хотите ударить: ");
            which_enemy = Convert.ToByte(Console.ReadLine());
            switch (which_enemy)
            {
                case (1):
                    if (hit > 3)
                        enemy[0].hp -= (int)(Math.Round(hero.damage * (1f - enemy[0].defence)));
                    else
                    {
                        Battlefield.Helping(10, 25, hero.name + " промахнулся");
                        Thread.Sleep(400);
                    }
                    break;
                case (2):
                    if (hit > 3)
                        enemy[1].hp -= (int)(Math.Round(hero.damage * (1f - enemy[1].defence)));
                    else
                    {
                        Battlefield.Helping(10, 25, hero.name + " промахнулся");
                        Thread.Sleep(400);
                    }
                    break;
                case (3):
                    if (hit > 3)
                        enemy[2].hp -= (int)(Math.Round(hero.damage * (1f - enemy[2].defence)));
                    else
                    {
                        Battlefield.Helping(10, 25, hero.name + " промахнулся");
                        Thread.Sleep(400);
                    }
                    break;
                case (4):
                    if (hit > 3)
                        enemy[3].hp -= (int)(Math.Round(hero.damage * (1f - enemy[3].defence)));
                    else
                    {
                        Battlefield.Helping(10, 25, hero.name + " промахнулся");
                        Thread.Sleep(400);
                    }
                    break;
            }
            Battlefield.Helping(Convert.ToInt32(hero.x) - 6, Convert.ToInt32(hero.y + 1), "-");
            Thread.Sleep(250);
            Battlefield.Helping(Convert.ToInt32(hero.x) - 7, Convert.ToInt32(hero.y + 1), "-");
            Thread.Sleep(250);
            Battlefield.Helping(Convert.ToInt32(hero.x) - 8, Convert.ToInt32(hero.y + 1), "-");
            Thread.Sleep(250);
        }

        public void Deffence(MainCharacter hero)
        {
            hero.defence += 0.25f;
        }

        public void Back(MainCharacter hero)
        {
            hero.defence -= 0.25f;
        }

        public void Use(MainCharacter hero1, MainCharacter hero2, MainCharacter hero3, MainCharacter hero4)
        {
            Battlefield.Helping(10, 25, "Выберите предмет, который вы хотите использовать:");
            Battlefield.Helping(10, 26, "1. Малое зелье лечения");
            Battlefield.Helping(10, 27, "2. Среднее зелье лечения");
            Battlefield.Helping(10, 28, "3. Большое зелье лечения");
            Battlefield.Helping(10, 29, "4. Зелье восстановления маны");
            Battlefield.Helping(10, 30, "5. Зелье воскрешения");
            Battlefield.Helping(10, 31, "Ваш выбор: ");
            byte a = Convert.ToByte(Console.ReadLine());
            byte b;
            switch(a)
            {
                case (1):
                    Battlefield.Helping(50, 26, "Выберите на ком вы хотите применить данное зелье: ");
                    Battlefield.Helping(50, 27, "1. " + hero1.name);
                    Battlefield.Helping(50, 28, "2. " + hero2.name);
                    Battlefield.Helping(50, 29, "3. " + hero3.name);
                    Battlefield.Helping(50, 30, "4. " + hero4.name);
                    Battlefield.Helping(50, 31, "Ваш выбор: ");
                    b = Convert.ToByte(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            LittlePoition.Heal(inventory.items, hero1);
                            break;
                        case (2):
                            LittlePoition.Heal(inventory.items, hero2);
                            break;
                        case (3):
                            LittlePoition.Heal(inventory.items, hero3);
                            break;
                        case (4):
                            LittlePoition.Heal(inventory.items, hero4);
                            break;
                    }
                    break;
                case (2):
                    Battlefield.Helping(50, 26, "Выберите на ком вы хотите применить данное зелье: ");
                    Battlefield.Helping(50, 27, "1. " + hero1.name);
                    Battlefield.Helping(50, 28, "2. " + hero2.name);
                    Battlefield.Helping(50, 29, "3. " + hero3.name);
                    Battlefield.Helping(50, 30, "4. " + hero4.name);
                    Battlefield.Helping(50, 31, "Ваш выбор: ");
                    b = Convert.ToByte(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            MiddlePoition.Heal(inventory.items, hero1);
                            break;
                        case (2):
                            MiddlePoition.Heal(inventory.items, hero2);
                            break;
                        case (3):
                            MiddlePoition.Heal(inventory.items, hero3);
                            break;
                        case (4):
                            MiddlePoition.Heal(inventory.items, hero4);
                            break;
                    }
                    break;
                case (3):
                    Battlefield.Helping(50, 26, "Выберите на ком вы хотите применить данное зелье: ");
                    Battlefield.Helping(50, 27, "1. " + hero1.name);
                    Battlefield.Helping(50, 28, "2. " + hero2.name);
                    Battlefield.Helping(50, 29, "3. " + hero3.name);
                    Battlefield.Helping(50, 30, "4. " + hero4.name);
                    Battlefield.Helping(50, 31, "Ваш выбор: ");
                    b = Convert.ToByte(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            BigPoition.Heal(inventory.items, hero1);
                            break;
                        case (2):
                            BigPoition.Heal(inventory.items, hero2);
                            break;
                        case (3):
                            BigPoition.Heal(inventory.items, hero3);
                            break;
                        case (4):
                            BigPoition.Heal(inventory.items, hero4);
                            break;
                    }
                    break;
                case (4):
                    Battlefield.Helping(50, 26, "Выберите на ком вы хотите применить данное зелье: ");
                    Battlefield.Helping(50, 27, "1. " + hero1.name);
                    Battlefield.Helping(50, 28, "2. " + hero2.name);
                    Battlefield.Helping(50, 29, "3. " + hero3.name);
                    Battlefield.Helping(50, 30, "4. " + hero4.name);
                    Battlefield.Helping(50, 31, "Ваш выбор: ");
                    b = Convert.ToByte(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            Coffee.Restores_SP(inventory.items, hero1);
                            break;
                        case (2):
                            Coffee.Restores_SP(inventory.items, hero2);
                            break;
                        case (3):
                            Coffee.Restores_SP(inventory.items, hero3);
                            break;
                        case (4):
                            Coffee.Restores_SP(inventory.items, hero4);
                            break;
                    }
                    break;
                case (5):
                    Battlefield.Helping(50, 26, "Выберите на ком вы хотите применить данное зелье: ");
                    Battlefield.Helping(50, 27, "1. " + hero1.name);
                    Battlefield.Helping(50, 28, "2. " + hero2.name);
                    Battlefield.Helping(50, 29, "3. " + hero3.name);
                    Battlefield.Helping(50, 30, "4. " + hero4.name);
                    Battlefield.Helping(50, 31, "Ваш выбор: ");
                    b = Convert.ToByte(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            PhoenixDown.Resurrection(inventory.items, hero1);
                            break;
                        case (2):
                            PhoenixDown.Resurrection(inventory.items, hero2);
                            break;
                        case (3):
                            PhoenixDown.Resurrection(inventory.items, hero3);
                            break;
                        case (4):
                            PhoenixDown.Resurrection(inventory.items, hero4);
                            break;
                    }
                    break;
            }
        }
    }
}
