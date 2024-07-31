using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS
{
    public class HuntRifle
    {
        String magazine;
        int ammo;

        public HuntRifle(String magazine)
        {
            this.magazine = magazine;
        }
        public HuntRifle(String magazine, int ammo)
        {
            this.magazine = magazine;
            this.ammo = ammo;
        }
        public void Carbine() 
        {
            if (ammo <= 0 && magazine != null)
            {
                if (ammo > 8) { ammo = 8; }
                Console.WriteLine("\n[Magazine]: Makes chambering bullets is a lot faster");
                Console.WriteLine("There is no ammunition");
            }
            else if (ammo > 0 && (magazine != null && magazine != ""))
            {
                if (ammo > 8) { ammo = 8; }
                Console.Write("\nThere is ammunition. (" + ammo + " Rounds left)");
                Console.WriteLine("\n[Magazine]: Makes chambering bullets a lot faster");
            }
            else if (ammo > 0 && (magazine == null || magazine == ""))
            {
                Console.Write("\nThere is ammunition. (" + ammo + "Rounds left)");
            }
            else
            {
                Console.Write("\nThere is no ammunition or magazine either.");
            }
        }
    }
}
