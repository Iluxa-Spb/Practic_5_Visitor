using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    class Project : ProjectElement
    {
        ProjectElement[] projectElements;
        public Project()
        {
            this.projectElements = new ProjectElement[]
            {
                new ProjectClass(),
                new Database(),
                new Test()
            };
        }
        public void beWriteln(Developer developer)
        {
            foreach(ProjectElement element in projectElements)
            {
                element.beWriteln(developer);
            }
        }
    }
}
