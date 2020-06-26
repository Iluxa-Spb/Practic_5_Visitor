using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class ProjectClass : ProjectElement
    {
        public void beWriteln(Developer developer)
        {
            developer.create(this);
        }
    }
}
