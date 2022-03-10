using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Bad1
{
    public class Swordman
    {
        protected int _attack;
        public Swordman(int attack)
        {
            _attack = attack;
        }

        public int AttackBySword => _attack;
    }
}
