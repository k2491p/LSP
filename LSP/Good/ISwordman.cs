using System;
using System.Collections.Generic;
using System.Text;
using static LSP.Good.Util;

namespace LSP.Good
{
    interface ISwordman
    {
        public Weapons Weapon { get; }
        public int Attack { get;  }
    }
}
