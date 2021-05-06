using System;

namespace hw5
{
    internal sealed class Mage : IUnit
    {
        private int _hp;
        private int _mana;
        public int HP => _hp;

        internal Mage(int hp,int mana)
        {
            _hp = hp;
            _mana = mana;
            Console.WriteLine($"Create Mage: HP:{hp} Mana:{mana}");
        }
    }
}
