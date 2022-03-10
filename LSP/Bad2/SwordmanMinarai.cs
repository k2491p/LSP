using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Bad2
{
    public sealed class SwordmanMinarai : ISwordman
    {
        private int _attack;
        public SwordmanMinarai(int attack)
        {
            _attack = attack;
        }
        public int Attack => (int)(_attack * 0.5);
        public int AttackByWoodClub => _attack;
    }
}
