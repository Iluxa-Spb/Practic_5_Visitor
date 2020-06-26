using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    interface ProjectElement
    {
        public void beWriteln(Developer developer);
    }
}