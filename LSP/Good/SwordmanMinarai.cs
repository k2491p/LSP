using System;
using System.Collections.Generic;
using System.Text;
using static LSP.Good.Util;

namespace LSP.Good
{
    public sealed class SwordmanMinarai : ISwordman
    {
        public SwordmanMinarai(Weapons weapon, int attack)
        {
            Weapon = weapon;
            _attack = attack;
        }
        public Weapons Weapon { get; }

        private int _attack;

        public int Attack
        {
            get
            {
                if (Weapon == Weapons.SWORD)
                {
                    return (int)(_attack * 0.5);
                }
                return _attack;
            }
        }
    }
}
