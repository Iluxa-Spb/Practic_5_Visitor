using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class JuniorDeveloper : Developer
    {
        public void create(ProjectClass projectClass)
        {
            Console.WriteLine("Writing poor class...");
        }

        public void create(Database database)
        {
            Console.WriteLine("Drop database...");
        }

        public void create(Test test)
        {
            Console.WriteLine("Creating not reliable test...");
        }
    }
}
