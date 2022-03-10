using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Bad1
{
    public class SwordmanMinarai : Swordman
    {
        public SwordmanMinarai(int attack) : base(attack)
        {
        }

        public int AttackBySword => (int)(_attack * 0.5);

        public int AttackByWoodClub => _attack;
    }
}
