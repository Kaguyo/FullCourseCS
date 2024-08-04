using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    class Armas
    {
        public virtual void Arsenal()
        {

        }
        public string gunName;
        public int capacityMag;
        public virtual void DisplayGunName()
        {
            Console.WriteLine("The gun has a name");
        }
        public virtual void DisplayMagazineSize()
        {
            Console.WriteLine("The gun has bullets capacity");
        }
    }
}
