using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    class Characters
    {
        public string name;
        public int age;

        public void Introduce()
        {
            if (name == "Blade" || name == "blade")
            {
                Console.WriteLine(name + ": Hmph...");
            }
            Console.Write($"Hello, my name is {name}");
            if (name == "Naruto Uzumaki")
            {
                Console.WriteLine(", and I will be a great Hokage, Dattebayo!");
            }
            else { Console.WriteLine("\n"); }
        }
    }
}
