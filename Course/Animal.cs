using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    public class Animal
    {
        // Abstract classes = modifier that indicates missing components or incomplete implementation
        public string id = "";
        public double maxSpeed = 0;
        public double speed = 0;
        public double weight = 0;
        public string type = "";
        public void move(string animalId, double animalSpeed, double animalWeight, string animalType, double animalMaxSpeed)
        {
            if (animalType == "Predator" && animalMaxSpeed / animalSpeed <= 1.3333333333)
            {
                Console.WriteLine($"{animalId} is hunting! ({animalSpeed} Km/h).");
            }
            else if ((animalType == "Predator" || animalType == "Prey") && animalMaxSpeed / animalSpeed > 1.3333333333 && animalMaxSpeed / animalSpeed <= 2)
            {
                Console.WriteLine($"{animalId} is running. ({animalSpeed} Km/h).");
            }
            else if (animalType == "Prey" && animalMaxSpeed / animalSpeed < 1.3333333333)
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
