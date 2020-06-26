using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class Test : ProjectElement
    {
        public void beWriteln(Developer developer)
        {
            developer.create(this);
        }
    }
}
