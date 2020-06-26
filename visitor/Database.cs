using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class Database : ProjectElement
    {
        public void beWriteln(Developer developer)
        {
            developer.create(this);
        }
    }
}
