using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class SeniorDeveloper : Developer
    {
        public void create(ProjectClass projectClass)
        {
            Console.WriteLine("Rewriting class after junior...");
        }

        public void create(Database database)
        {
            Console.WriteLine("Fixing database...");
        }

        public void create(Test test)
        {
            Console.WriteLine("Creating reliable test...");
        }
    }
}
