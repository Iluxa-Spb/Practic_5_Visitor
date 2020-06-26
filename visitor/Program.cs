using System;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project();

            Developer junior = new JuniorDeveloper();
            Developer senior = new SeniorDeveloper();

            Console.WriteLine("Junior in action...");
            project.beWriteln(junior);

            Console.WriteLine("\n ==================================\n");

            Console.WriteLine("Senior in action...");
            project.beWriteln(senior);
        }
    }
}
