using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Bad2
{
    public sealed class Swordman : ISwordman
    {
        private int _attack;
        public Swordman(int attack)
        {
            _attack = attack;
        }
        public int Attack => _attack;
    }
}
