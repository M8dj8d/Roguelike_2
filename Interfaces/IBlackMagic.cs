using System;

namespace Roguelike_2
{
    interface IBlackMagic
    {
        void Agi(Enemy enemy, BlackMage mage, byte hit);
        void Agilao(Enemy enemy, BlackMage mage, byte hit);
        void Agidyne(Enemy enemy, BlackMage mage, byte hit);

        void Bufu(Enemy enemy, BlackMage mage, byte hit);
        void Bufula(Enemy enemy, BlackMage mage, byte hit);
        void Bufudyne(Enemy enemy, BlackMage mage, byte hit);

        void Zio(Enemy enemy, BlackMage mage, byte hit);
        void Zionga(Enemy enemy, BlackMage mage, byte hit);
        void Ziodyne(Enemy enemy, BlackMage mage, byte hit);

        void Garu(Enemy enemy, BlackMage mage, byte hit);
        void Garula(Enemy enemy, BlackMage mage, byte hit);
        void Garudyne(Enemy enemy, BlackMage mage, byte hit);
    }
}
