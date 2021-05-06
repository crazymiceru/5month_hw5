using System;

namespace hw5
{
    internal sealed class Infantry : IUnit
    {
        private int _hp;
         public int HP => _hp;

        internal Infantry(int hp)
        {
            _hp = hp;
            Console.WriteLine($"Create Infantry: HP:{hp}");
        }
    }
}
