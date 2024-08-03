using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS
{
    public class Animal
    {
        // Abstract classes = modifier that indicates missing components or incomplete implementation
        public String id = "";
        public double maxSpeed = 0;
        public double speed = 0;
        public double weight = 0;
        public String type = "";
        public void move(String animalId, double animalSpeed, double animalWeight, String animalType, double animalMaxSpeed)
        {
            if (animalType == "Predator" && animalMaxSpeed / animalSpeed <= 1.3333333333)
            {
                Console.WriteLine($"{animalId} is hunting! ({animalSpeed} Km/h).");
            }
            else if (animalType == "Prey" && animalMaxSpeed / animalSpeed <= 1.3333333333)
            {
                Console.WriteLine($"{animalId} is fleeing! ({animalSpeed} Km/h).");
            }
            else if (animalSpeed == 0) 
            {
                Console.WriteLine($"{animalId} is staying still.");
            }
            else { Console.WriteLine($"{animalId} is moving. ({animalSpeed} Km/h)."); }
        }
    }
}
