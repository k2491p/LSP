using System;
using static LSP.Good.Util;

namespace LSP.Good
{
    public sealed class Swordman : ISwordman
    {
        public Swordman(Weapons weapon, int attack)
        {
            if (weapon != Weapons.SWORD)
            {
                throw new Exception("剣士には剣のみセットできます");
            }
            Weapon = weapon;
            Attack = attack;
        }
        public Weapons Weapon { get; }

        public int Attack { get; }
    }
}
