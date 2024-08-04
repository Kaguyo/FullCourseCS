using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    class M4a1 : Armas
    {
        public override void DisplayGunName()
        {
            Console.WriteLine($"Gun name: {gunName}");
        }
        public override void DisplayMagazineSize()
        {
            Console.WriteLine($"Capacity: {capacityMag}");
        }
        public override void Arsenal()
        {
            Console.WriteLine($"{gunName} is stored in the Arsenal");
        }
    }
}
