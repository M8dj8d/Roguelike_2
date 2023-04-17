using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Battlefield  //класс, отвечающий за отображение поля боя
    {
        public static void Pole(Knight knight, Thieve thieve, BlackMage blmage, WhiteMage whmage, List<Enemy> enemy)
        {
            byte turn = 0;                              //переменная которая фиксирует чей сейчас ход
            byte coordinates = 0;                           //хранит координаты курсора при выборе действия
            Random rnd = new Random();
            byte hit_chance;
            byte concentrate = 0;
            byte end = 0;
            byte[] def = new byte[4] { 0, 0, 0, 0};

            do
            {
                turn++;
                Console.Clear();                        //очищает консоль от лишних символов
                if (turn == 1 && knight.hp <= 0)
                    continue;
                if (turn == 2 && thieve.hp <= 0)
                    continue;
                if (turn == 3 && blmage.hp <= 0)
                    continue;
                if (turn == 4 && whmage.hp <= 0)
                    continue;
                if (knight.hp > 0)
                    knight.battlesym = 'K';
                if (thieve.hp > 0)
                    thieve.battlesym = 'T';
                if (blmage.hp > 0)
                    blmage.battlesym = 'M';
                if (whmage.hp > 0)
                    whmage.battlesym = 'W';


                switch (turn)                            //позволяет выдвинуть вперед персонажа, который совершает ход
                {
                    case (1):
                        Person(knight.x -5, knight.y, knight.ix, knight.iy, knight.battlesym);                  //отображение первого персонажа
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        for (int i = 0; i < 4; i++)             
                        {
                            Person(enemy[i].x, enemy[i].y, enemy[i].ix, enemy[i].iy, enemy[i].battlesym);
                        }
                        break;
                    case (2):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x -5, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);                  //отображение второго персонажа
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        for (int i = 0; i < 4; i++)             
                        {
                            Person(enemy[i].x, enemy[i].y, enemy[i].ix, enemy[i].iy, enemy[i].battlesym);
                        }
                        break;
                    case (3):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x - 5, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);                  //отображение третьего персонажа
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        for (int i = 0; i < 4; i++)            
                        {
                            Person(enemy[i].x, enemy[i].y, enemy[i].ix, enemy[i].iy, enemy[i].battlesym);
                        }
                        break;
                    case (4):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x - 5, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);                  //отображение четрвертого персонажа
                        for (int i = 0; i < 4; i++)             
                        {
                            Person(enemy[i].x, enemy[i].y, enemy[i].ix, enemy[i].iy, enemy[i].battlesym);
                        }
                        break;
                    case (5):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);                  
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        Person(enemy[0].x + 5, enemy[0].y, enemy[0].ix, enemy[0].iy, enemy[0].battlesym);
                        Person(enemy[1].x, enemy[1].y, enemy[1].ix, enemy[1].iy, enemy[1].battlesym);
                        Person(enemy[2].x, enemy[2].y, enemy[2].ix, enemy[2].iy, enemy[2].battlesym);
                        Person(enemy[3].x, enemy[3].y, enemy[3].ix, enemy[3].iy, enemy[3].battlesym);
                        break;
                    case (6):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        Person(enemy[0].x, enemy[0].y, enemy[0].ix, enemy[0].iy, enemy[0].battlesym);
                        Person(enemy[1].x + 5, enemy[1].y, enemy[1].ix, enemy[1].iy, enemy[1].battlesym);
                        Person(enemy[2].x, enemy[2].y, enemy[2].ix, enemy[2].iy, enemy[2].battlesym);
                        Person(enemy[3].x, enemy[3].y, enemy[3].ix, enemy[3].iy, enemy[3].battlesym);
                        break;
                    case (7):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        Person(enemy[0].x, enemy[0].y, enemy[0].ix, enemy[0].iy, enemy[0].battlesym);
                        Person(enemy[1].x, enemy[1].y, enemy[1].ix, enemy[1].iy, enemy[1].battlesym);
                        Person(enemy[2].x + 5, enemy[2].y, enemy[2].ix, enemy[2].iy, enemy[2].battlesym);
                        Person(enemy[3].x, enemy[3].y, enemy[3].ix, enemy[3].iy, enemy[3].battlesym);
                        break; 
                    case (8):
                        Person(knight.x, knight.y, knight.ix, knight.iy, knight.battlesym);
                        Person(thieve.x, thieve.y, thieve.ix, thieve.iy, thieve.battlesym);
                        Person(blmage.x, blmage.y, blmage.ix, blmage.iy, blmage.battlesym);
                        Person(whmage.x, whmage.y, whmage.ix, whmage.iy, whmage.battlesym);
                        Person(enemy[0].x, enemy[0].y, enemy[0].ix, enemy[0].iy, enemy[0].battlesym);
                        Person(enemy[1].x, enemy[1].y, enemy[1].ix, enemy[1].iy, enemy[1].battlesym);
                        Person(enemy[2].x, enemy[2].y, enemy[2].ix, enemy[2].iy, enemy[2].battlesym);
                        Person(enemy[3].x + 5, enemy[3].y, enemy[3].ix, enemy[3].iy, enemy[3].battlesym);
                        break;
                    
                }


                Interface(knight, thieve, blmage, whmage);          //отрисовывает показатели персонажей
                if (turn <= 4)
                {
                    Helping(100, 18, "1. Атака");                  //отображает действия, которые может выбрать игрок
                    Helping(100, 19, "2. Защита");
                    switch (turn)                               //это часть у каждого персонажа разная
                    {
                        case (1): Helping(100, 20, "3. " + knight.specaction); break;
                        case (2): Helping(100, 20, "3. " + thieve.specaction); break;
                        case (3): Helping(100, 20, "3. " + blmage.specaction); break;
                        case (4): Helping(100, 20, "3. " + whmage.specaction); break;
                        default: break;
                    }
                    Helping(100, 21, "4. Предмет");
                    Helping(100, 22, "5. Побег");
                    Helping(100, 23, "Выберите действие: ");
                    coordinates = Convert.ToByte(Console.ReadLine());

                    switch (coordinates)                                    //выполняет действие, которое выбрал игрок
                    {
                        case (1):                                          //атака персонажа
                            switch (turn)                                    //какой именно персонаж атакует
                            {
                                case (1):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    knight.Attak(knight, ref enemy, hit_chance);
                                    if (def[0] == 1)
                                        knight.Back(knight);
                                    if (concentrate == 3)
                                        knight.Return(knight);
                                    break;
                                case (2):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[1] == 1)
                                        thieve.Back(thieve);
                                    thieve.Attak(thieve, ref enemy, hit_chance);
                                    break;
                                case (3):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[2] == 1)
                                        blmage.Back(blmage);
                                    blmage.Attak(blmage, ref enemy, hit_chance);
                                    break;
                                case (4):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[3] == 1)
                                        whmage.Back(whmage);
                                    whmage.Attak(whmage, ref enemy, hit_chance);
                                    break;
                            }
                            break;
                        case (2):                               //увеличение защиты у персонажа
                            switch (turn)                       //какой именно персонаж
                            {
                                case (1):
                                    knight.Deffence(knight);                                    
                                    if (def[0] == 1)
                                        knight.Back(knight);
                                    if (concentrate == 3)
                                        knight.Return(knight);
                                    def[0] = 1;
                                    continue;
                                case (2):
                                    thieve.Deffence(thieve);
                                    if (def[1] == 1)
                                        thieve.Back(thieve);
                                    def[1] = 1;
                                    continue;
                                case (3):
                                    blmage.Deffence(blmage);
                                    if (def[2] == 1)
                                        blmage.Back(blmage);
                                    def[2] = 1;
                                    continue;
                                case (4):
                                    whmage.Deffence(whmage);
                                    if (def[3] == 1)
                                        whmage.Back(whmage);
                                    def[3] = 1;
                                    continue;
                            }
                            break;
                        case (3):                                   //особое действие персонажа
                            switch (turn)
                            {
                                case (1):                           //увеличение урона вдвое
                                    if (def[0] == 1)
                                        knight.Back(knight);
                                    knight.Concentrate(knight);
                                    if (concentrate == 3)
                                        knight.Return(knight);
                                    concentrate = 3;
                                    continue;
                                case (2):                           //воровство предмета
                                    thieve.Steal(enemy);
                                    if (def[1] == 1)
                                        thieve.Back(thieve);
                                    break;
                                case (3):                           //черная магия
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[2] == 1)
                                        blmage.Back(blmage);
                                    BlackMagic(blmage, ref enemy, hit_chance);
                                    break;
                                case (4):                           //белая магия
                                    WhiteMagic(knight, thieve, blmage, whmage);
                                    if (def[3] == 1)
                                        whmage.Back(whmage);
                                    break;
                            }
                            break;
                        case (4):                                   //использование предмета
                            switch (turn)
                            {
                                case (1):
                                    if (def[0] == 1)
                                        knight.Back(knight);
                                    if (concentrate == 3)
                                        knight.Return(knight);
                                    knight.Use(knight, thieve, blmage, whmage);
                                    break;
                                case (2):
                                    if (def[1] == 1)
                                        thieve.Back(thieve);
                                    thieve.Use(knight, thieve, blmage, whmage);
                                    break;
                                case (3):
                                    if (def[2] == 1)
                                        blmage.Back(blmage);
                                    blmage.Use(knight, thieve, blmage, whmage);
                                    break;
                                case (4):
                                    if (def[3] == 1)
                                        whmage.Back(whmage);
                                    whmage.Use(knight, thieve, blmage, whmage);
                                    break;
                            }
                            break;
                        case (5):                                   //попытка сбежать с поля боя
                            switch (turn)
                            {
                                case (1):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[0] == 1)
                                        knight.Back(knight);
                                    if (concentrate == 3)
                                        knight.Return(knight);
                                    if (hit_chance > 9)
                                        end = 10;
                                    break;
                                case (2):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[1] == 1)
                                        thieve.Back(thieve);
                                    if (hit_chance > 6)
                                        end = 10;
                                    break;
                                case (3):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[2] == 1)
                                        blmage.Back(blmage);
                                    if (hit_chance > 7)
                                        end = 10;
                                    break;
                                case (4):
                                    hit_chance = (byte)rnd.Next(1, 10);
                                    if (def[3] == 1)
                                        whmage.Back(whmage);
                                    if (hit_chance > 7)
                                        end = 10;
                                    break;
                            }
                            break;

                    }
                }

                switch (turn)                                    //атака противников
                {
                    case (5):
                        if (enemy[0].hp > 0)
                        {
                            hit_chance = (byte)rnd.Next(0, 20);
                            if (hit_chance >= 0 && hit_chance <= 4 && knight.hp > 0)
                                enemy[0].Attak(enemy[0], knight);
                            if (hit_chance >= 6 && hit_chance <= 10 && thieve.hp > 0)
                                enemy[0].Attak(enemy[0], thieve);
                            if (hit_chance >= 12 && hit_chance <= 15 && blmage.hp > 0)
                                enemy[0].Attak(enemy[0], blmage);
                            if (hit_chance >= 17 && hit_chance <= 20 && whmage.hp > 0)
                                enemy[0].Attak(enemy[0], whmage);
                        }
                        break;
                    case (6):
                        if (enemy[1].hp > 0)
                        {
                            hit_chance = (byte)rnd.Next(0, 20);
                            if (hit_chance >= 0 && hit_chance <= 4 && knight.hp > 0)
                                enemy[1].Attak(enemy[1], knight);   
                            if (hit_chance >= 6 && hit_chance <= 10 && thieve.hp > 0)
                                enemy[1].Attak(enemy[1], thieve);
                            if (hit_chance >= 12 && hit_chance <= 15 && blmage.hp > 0)
                                enemy[1].Attak(enemy[1], blmage);
                            if (hit_chance >= 17 && hit_chance <= 20 && whmage.hp > 0)
                                enemy[1].Attak(enemy[1], whmage);
                        }
                        break;
                    case (7):
                        if (enemy[2].hp > 0)
                        {
                            hit_chance = (byte)rnd.Next(0, 20);
                            if (hit_chance >= 0 && hit_chance <= 4 && knight.hp > 0)
                                enemy[2].Attak(enemy[2], knight);
                            if (hit_chance >= 6 && hit_chance <= 10 && thieve.hp > 0)
                                enemy[2].Attak(enemy[2], thieve);
                            if (hit_chance >= 12 && hit_chance <= 15 && blmage.hp > 0)
                                enemy[2].Attak(enemy[2], blmage);
                            if (hit_chance >= 17 && hit_chance <= 20 && whmage.hp > 0)
                                enemy[2].Attak(enemy[2], whmage);
                        }
                        break;
                    case (8):
                        if (enemy[3].hp > 0)
                        {
                            hit_chance = (byte)rnd.Next(0, 20);
                            if (hit_chance >= 0 && hit_chance <= 4 && knight.hp > 0)
                                enemy[3].Attak(enemy[3], knight);
                            if (hit_chance >= 6 && hit_chance <= 10 && thieve.hp > 0)
                                enemy[3].Attak(enemy[3], thieve);
                            if (hit_chance >= 12 && hit_chance <= 15 && blmage.hp > 0)
                                enemy[3].Attak(enemy[3], blmage);
                            if (hit_chance >= 17 && hit_chance <= 20 && whmage.hp > 0)
                                enemy[3].Attak(enemy[3], whmage);
                        }
                        break;
                }


                for (int i = 0; i < 4; i++)                 //отображает мертывых противников
                {
                    if (enemy[i].hp <= 0)
                    {
                        enemy[i].battlesym = '+';
                    }
                    else if (turn == 8)                     //обновляет ходы персонажей
                    {
                        turn = 0;
                    }
                }
                if (knight.hp <= 0)
                {
                    knight.battlesym = '+';
                    knight.hp = 0;
                }
                if (thieve.hp <= 0)
                {
                    thieve.battlesym = '+';
                    thieve.hp = 0;
                }
                if (blmage.hp <= 0)
                {
                    blmage.battlesym = '+';
                    blmage.hp = 0;
                }
                if (whmage.hp <= 0)
                {
                    whmage.battlesym = '+';
                    whmage.hp = 0;
                }
                if (knight.hp <= 0 && thieve.hp <= 0 && blmage.hp <= 0 && whmage.hp <= 0)
                    turn = 9;
                


                if(turn == 1)
                {
                    concentrate = 0;
                    def[0] = 0;
                }
                if (turn == 2)
                    def[1] = 0;
                if (turn == 3)
                    def[2] = 0;
                if (turn == 4)
                    def[3] = 0;
            } while (turn != 9 || end != 10);

        }



        public static void Helping(int x, int y, string action)        //помогает отображать дейстия, которые может выполнить игрок
        {
            Console.SetCursorPosition(x, y);
            Console.Write(action);
        }
        


        private static void Person(float x, float y, int ix, int iy, char sym)      //Помогает отображать персонажа на экране
        {
            for (int i = 0; i < ix; i++)
            {
                for (int j = 0; j < iy; j++)
                {
                    Helping(Convert.ToInt32(x) + i, Convert.ToInt32(y) + j, Convert.ToString(sym));
                }
            }
        }

                        
        private static void BlackMagic(BlackMage hero, ref List<Enemy> enemy, byte hit)       //отвечает за воспроизводство черной магии
        {
            byte cursor;
            byte which_enemy;
            Console.SetCursorPosition(10, 25);
            Console.WriteLine("Выберите заклинание:");
            if (hero.lvl <= 5)                                  //проверяет уровень героя
            {                                                   //с первого по пятый уровень отображаются заклинания первого уровня
                Helping(10, 26, "1. Agi");                         //заклинание огня 
                Helping(10, 27, "2. Bufu");                        //заклинание льда 
                Helping(10, 28, "3. Garu");                        //заклинание ветра 
                Helping(10, 29, "4. Zio");                         //заклинание электричества 
                Helping(10, 30, "Введите номер заклинания, которое вы хотите использовать: ");
                cursor = Convert.ToByte(Console.ReadLine());
                Helping(10, 31, "Введите номер противника, которого вы хотите поразить заклинанием: ");
                which_enemy = Convert.ToByte(Console.ReadLine());
                switch (cursor)
                {
                    case (1):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Agi(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Agi(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Agi(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Agi(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (2):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Bufu(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Bufu(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Bufu(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Bufu(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (3):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Garu(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Garu(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Garu(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Garu(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (4):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Zio(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Zio(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Zio(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Zio(enemy[3], hero, hit);
                                break;
                        }
                        break;
                }
            }
            if (hero.lvl > 5 && hero.lvl <= 10)
            {
                Helping(10, 26, "1. Agilao");                       //заклинание огня второго уровня
                Helping(10, 27, "2. Bufula");                       //заклинание льда второго уровня
                Helping(10, 28, "3. Garula");                       //заклинание ветра второго уровня
                Helping(10, 29, "4. Zionga");                       //заклинание молнии второго уровня
                Helping(10,30, "Введите номер заклинания, которое вы хотите использовать: ");
                cursor = Convert.ToByte(Console.ReadLine());
                Helping(10, 31, "Введите номер противника, которого вы хотите поразить заклинанием: ");
                which_enemy = Convert.ToByte(Console.ReadLine());
                switch (cursor)
                {
                    case (1):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Agilao(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Agilao(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Agilao(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Agilao(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (2):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Bufula(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Bufula(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Bufula(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Bufula(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (3):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Garula(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Garula(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Garula(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Garula(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (4):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Zionga(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Zionga(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Zionga(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Zionga(enemy[3], hero, hit);
                                break;
                        }
                        break;
                }
            }
            if (hero.lvl > 10)
            {
                Helping(10, 26, "1. Agidyne");                      //заклинание огня третьего уровня
                Helping(10, 27, "2. Bufudyne");                     //заклинание льда третьего уровня
                Helping(10, 28, "3. Garudyne");                     //заклинание ветра третьего уровня
                Helping(10, 29, "4. Ziodyne");                      //заклинание молнии третьего уровня
                Console.SetCursorPosition(10, 30);
                Helping(10, 30, "Введите номер заклинания, которое вы хотите использовать: ");
                cursor = Convert.ToByte(Console.ReadLine());
                Helping(10, 31, "Введите номер противника, которого вы хотите поразить заклинанием: ");
                which_enemy = Convert.ToByte(Console.ReadLine());
                switch (cursor)
                {
                    case (1):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Agidyne(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Agidyne(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Agidyne(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Agidyne(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (2):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Bufudyne(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Bufudyne(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Bufudyne(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Bufudyne(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (3):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Garudyne(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Garudyne(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Garudyne(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Garudyne(enemy[3], hero, hit);
                                break;
                        }
                        break;
                    case (4):
                        switch (which_enemy)
                        {
                            case (1):
                                Magic_Animatoin(enemy[0]);
                                hero.Ziodyne(enemy[0], hero, hit);
                                break;
                            case (2):
                                Magic_Animatoin(enemy[1]);
                                hero.Ziodyne(enemy[1], hero, hit);
                                break;
                            case (3):
                                Magic_Animatoin(enemy[2]);
                                hero.Ziodyne(enemy[2], hero, hit);
                                break;
                            case (4):
                                Magic_Animatoin(enemy[3]);
                                hero.Ziodyne(enemy[3], hero, hit);
                                break;
                        }
                        break;
                }
            }
        }



        private static void Magic_Animatoin(Enemy enemy)                        //отвечает за анимацию заклинаний черной магии
        {
            Helping((int)enemy.x + 3, (int)enemy.y + 3, "* *");
            Thread.Sleep(200);
            Helping((int)enemy.x + 4, (int)enemy.y + 2, "*");
            Thread.Sleep(200);
            Helping((int)enemy.x + 3, (int)enemy.y + 1, "***");
            Thread.Sleep(200);
            Helping((int)enemy.x + 4, (int)enemy.y, "*");
            Thread.Sleep(200); 
            Helping((int)enemy.x + 3, (int)enemy.y - 1, "* *");
            Thread.Sleep(200);
        }           



        private static void WhiteMagic(MainCharacter knight, MainCharacter thieve, MainCharacter blmage, WhiteMage whmage)      //отвечает за воспроизводство белой магии
        {
            short a;
            short b;
            Helping(10, 25, "Выберите заклинание:");
            if(whmage.lvl <= 5)
            {
                Helping(10, 26, "1 Dia");
                Helping(10, 27, "2 Recarm");
                Helping(10, 28, "Введите номер заклинания. Ваш выбор: ");
                a = Convert.ToInt16(Console.ReadLine());
                switch (a)
                {
                    case (1):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "4 " + whmage.name);
                        Helping(10, 34, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Dia(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Dia(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Dia(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                            case (4):
                                whmage.Dia(whmage, whmage);
                                White_Magic_Animation(whmage);
                                break;
                        }
                        break;
                    case (2):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Recarm(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Recarm(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Recarm(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                        }
                        break;
                }
            }
            if (whmage.lvl > 5 && whmage.lvl <= 10)
            {
                Helping(10, 26, "1 Diarahan");
                Helping(10, 27, "2 Recarm");
                Helping(10, 28, "Введите номер заклинания. Ваш выбор: ");
                a = Convert.ToInt16(Console.ReadLine());
                switch (a)
                {
                    case (1):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "4 " + whmage.name);
                        Helping(10, 34, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Diarahan(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Diarahan(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Diarahan(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                            case (4):
                                whmage.Diarahan(whmage, whmage);
                                White_Magic_Animation(whmage);
                                break;
                        }
                        break;
                    case (2):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Recarm(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Recarm(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Recarm(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                        }
                        break;
                }
            }
            if (whmage.lvl > 10)
            {
                Helping(10, 26, "1 Diarama");
                Helping(10, 27, "2 Recarm");
                Helping(10, 28, "Введите номер заклинания. Ваш выбор: ");
                a = Convert.ToInt16(Console.ReadLine());
                switch (a)
                {
                    case (1):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "4 " + whmage.name);
                        Helping(10, 34, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Diarama(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Diarama(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Diarama(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                            case (4):
                                whmage.Diarama(whmage, whmage);
                                White_Magic_Animation(whmage);
                                break;
                        }
                        break;
                    case (2):
                        Helping(10, 29, "Выберите союзника, на котором вы хотите применить заклинание:");
                        Helping(10, 30, "1 " + knight.name);
                        Helping(10, 31, "2 " + thieve.name);
                        Helping(10, 32, "3 " + blmage.name);
                        Helping(10, 33, "Ваш выбор: ");
                        b = Convert.ToInt16(Console.ReadLine());
                        switch (b)
                        {
                            case (1):
                                whmage.Recarm(whmage, knight);
                                White_Magic_Animation(knight);
                                break;
                            case (2):
                                whmage.Recarm(whmage, thieve);
                                White_Magic_Animation(thieve);
                                break;
                            case (3):
                                whmage.Recarm(whmage, blmage);
                                White_Magic_Animation(blmage);
                                break;
                        }
                        break;
                }
            }
        }



        private static void White_Magic_Animation(MainCharacter hero)           //отвечает за анимацию заклинаний белой магии
        {
            Helping((int)hero.x - 4, (int)hero.y + 2, "*");
            Thread.Sleep(200);
            Helping((int)hero.x - 5, (int)hero.y + 1, "***");
            Thread.Sleep(200);
            Helping((int)hero.x - 4, (int)hero.y, "*");
            Thread.Sleep(200);
        }



        private static void Interface(MainCharacter knight, MainCharacter thieve, MainCharacter blmage, MainCharacter whmage)
        {
            Console.SetCursorPosition(90, 4);
            Console.WriteLine("name: {0}\tHP: {1}\tSP: {2}\tDamage: {3}\tDefence: {4}\tGold: {5}", knight.name, knight.hp, knight.sp, knight.damage, knight.defence, knight.gold);
            Console.SetCursorPosition(90, 5);
            Console.WriteLine("name: {0}\tHP: {1}\tSP: {2}\tDamage: {3}\tDefence: {4}\tGold: {5}", thieve.name, thieve.hp, thieve.sp, thieve.damage, thieve.defence, thieve.gold);
            Console.SetCursorPosition(90, 6);
            Console.WriteLine("name: {0}\tHP: {1}\tSP: {2}\tDamage: {3}\tDefence: {4}\tGold: {5}", blmage.name, blmage.hp, blmage.sp, blmage.damage, blmage.defence, blmage.gold);
            Console.SetCursorPosition(90, 7);
            Console.WriteLine("name: {0}\tHP: {1}\tSP: {2}\tDamage: {3}\tDefence: {4}\tGold: {5}", whmage.name, whmage.hp, whmage.sp, whmage.damage, whmage.defence, whmage.gold);
        }    
    }
}
