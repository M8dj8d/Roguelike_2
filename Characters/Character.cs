using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_2
{
    class Character
    {
        public int damage;              //количество наносимого урона
        public float defence;           //коэффициент брони
        public int hp;                  //количество здоровья у персонажа
        public int sp;               //количество маны у персонажа
        //private string status;
        public float x, y;              //координаты верхнего угла русунка персонажа
        public int ix, iy;              //размер рисунка
        public char battlesym;          //иконка для боевого режима


        public Character( int damage, float defence, int hp, int sp, float x, float y, int ix, int iy, char battlesym)
        {
            this.damage = damage;
            this.defence = defence;
            this.hp = hp;
            this.sp = sp;
            this.x = x;
            this.y = y;
            this.ix = ix;
            this.iy = iy;
            this.battlesym = battlesym;
        }
    }
}
