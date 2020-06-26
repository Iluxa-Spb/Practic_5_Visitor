using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    interface Developer
    {
        public void create(ProjectClass projectClass);
        public void create(Database database);
        public void create(Test test);

    }
}
