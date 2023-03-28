using System;

namespace Roguelike_2
{
    interface IBlackMagic
    {
        void Agi(Enemy enemy, BlackMage mage);
        void Agilao(Enemy enemy, BlackMage mage);
        void Agidyne(Enemy enemy, BlackMage mage);

        void Bufu(Enemy enemy, BlackMage mage);
        void Bufula(Enemy enemy, BlackMage mage);
        void Bufudyne(Enemy enemy, BlackMage mage);

        void Zio(Enemy enemy, BlackMage mage);
        void Zionga(Enemy enemy, BlackMage mage);
        void Ziodyne(Enemy enemy, BlackMage mage);

        void Garu(Enemy enemy, BlackMage mage);
        void Garula(Enemy enemy, BlackMage mage);
        void Garudyne(Enemy enemy, BlackMage mage);
    }
}
