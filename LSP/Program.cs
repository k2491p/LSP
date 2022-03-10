using LSP.Bad1;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Swordman man1 = new Swordman(10);
            Swordman man2 = new SwordmanMinarai(5);

            Console.WriteLine(man1.AttackBySword);
        }
    }
}
