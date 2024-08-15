﻿using System;
using System.Collections.Generic;

namespace FullCourseCS.Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAula1 = false;
            if (playAula1)
            {
                string target = "Enemy";
                Aula1.slashEnemy(target);

                double a, b;
                try
                {
                    Console.Write("\nEnter in number 1: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter in number 2: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    // Call Multiply and store the result
                    double result = Aula1.Multiply(a, b);

                    // Output the result
                    Console.WriteLine($"\nThe result of multiplying {a} and {b} is: {result}");
                    double damage = Aula1.DamageCalculator(11023, 7292, 7292, 15721, 30200);
                    Console.WriteLine($"O dano causado pela sequência de acertos foi {damage}.");

                    //  Keqing's UltSkill DMG logic, plus  using alike named methods
                    Console.Write("Keqing's Ultimate first hit DMG: ");
                    double keqingUltFirstHit = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Keqing's Ultimate damage per slash: ");
                    double keqingUltSlashes = Convert.ToDouble(Console.ReadLine());
                    keqingUltSlashes *= 8;
                    Console.Write("Keqing's Ultimate last hit DMG: ");
                    double keqingUltLastHit = Convert.ToDouble(Console.ReadLine());
                    double keqingUltDmg = Aula1.DamageCalculator(keqingUltFirstHit, keqingUltSlashes, keqingUltLastHit);
                    Console.WriteLine($"O dano causado pela ult de Keqing foi de {keqingUltDmg}.\n");
                }
                catch (FormatException e)
                {
                    //  Console.WriteLine(e);
                    Console.WriteLine("Enter ONLY numbers!\n");
                }// END TRY

                string[,] personagens = { {"TrailBlazer", "Danheng","March7th","Asta", "Himeko", "Welt", "Herta", "Arlan"},
                                          {"Seele", "Bronya", "Pela", "Clara", "Sampo", "Serval", "Gepard", "Yanqing"},
                                          {"Kafka", "SilverWolf", "Blade", "Tingyun", "Lynx", "Hook", "Topaz","Dr.Ratio"}
                                        };

                for (int i = 0; i < personagens.GetLength(0); i++)
                {
                    for (int j = 0; j < personagens.GetLength(1); j++)
                    {
                        Console.Write(personagens[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nFim da aula 1.\n");
            }// END IF
            //  Class 1 END         ===================================================

            bool playAula2 = false;
            if (playAula2)
            {
                Characters naruto = new Characters();
                naruto.name = "Naruto Uzumaki";
                naruto.age = 15;
                naruto.Introduce();

                Car car1 = new Car("Ford", "Fusion", 2019, "Black");
                car1.Drive();

                HuntRifle huntRifle = new HuntRifle("8 Rounds Magazine", 8);
                huntRifle.Carbine();

                Console.WriteLine("\nFim da aula 2.\n");
            }// END IF
            //  Class 2 END         ===================================================
            bool playAula3 = false;
            if (playAula3)
            {
                // Abstract classes = modifier that indicates missing components or incomplete implementation
                Animal deer = new Animal();
                Animal cat = new Animal();
                Animal dog = new Animal();
                dog.maxSpeed = 40;
                dog.speed = 40;
                dog.id = "Bolt";
                dog.weight = 40;
                dog.type = "Predator";
                dog.move(dog.id, dog.speed, dog.weight, dog.type, dog.maxSpeed);

                cat.maxSpeed = 34;
                cat.speed = 5;
                cat.id = "Afonso";
                cat.weight = 6.5f;
                cat.type = "Predator";
                cat.move(cat.id, cat.speed, cat.weight, cat.type, cat.maxSpeed);

                deer.maxSpeed = 65;
                deer.speed = 0;
                deer.id = "Osvaldo";
                deer.weight = 70.7;
                deer.type = "Prey";
                deer.move(deer.id, deer.speed, deer.weight, deer.type, deer.maxSpeed);

                Console.WriteLine("\nFim da aula 3.\n");
            }// END IF
            //  Class 3 END         ===================================================
            bool playAula4 = false;
            if (playAula4)
            {
                Player1[] backpack = new Player1[3];

                Player1 slot1 = new Player1("Large Knife");
                Player1 slot2 = new Player1("5.56 Ammo");
                Player1 slot3 = new Player1("Makarov");

                backpack[0] = slot1;
                backpack[1] = slot2;
                backpack[2] = slot3;

                foreach (Player1 slot in backpack)
                { Console.WriteLine(slot.itemName); }

                //  Logica de upgrade item  ==========
                Console.WriteLine("\nApós upgrade:\n");
                Player1.UpgradeItem(slot1, slot1.itemName + "(Sharpness+)");
                foreach (Player1 slot in backpack)
                { Console.WriteLine(slot.itemName); }

                Console.WriteLine("\nFim da aula 4.\n");
            }// END IF
            //  Class 4 END         ===================================================
            bool playAula5 = false;
            if (playAula5)
            {   /* Override method. to create an overriding method,
                 the method that is inherited must be virtual, abstract or overrided. */
                M4a1 m4a1 = new M4a1();
                Kar98k kar98k = new Kar98k();

                kar98k.gunName = "Kar98K";
                kar98k.capacityMag = 5;
                kar98k.DisplayGunName();
                kar98k.DisplayMagazineSize();

                Console.WriteLine(); // ================ x =================

                m4a1.gunName = "M4A1";
                m4a1.capacityMag = 30;
                m4a1.DisplayGunName();
                m4a1.DisplayMagazineSize();

                Armas[] armas = { m4a1, kar98k };
                Console.WriteLine();
                foreach (Armas arma in armas)
                {
                    arma.Arsenal();
                }

                Console.WriteLine("\nFim da aula 5.\n");
            }// END IF
            //  Class 5 END         ===================================================
            bool playAula6 = true;
            if (playAula6)
            {
                String[] food = new string[3];

                food[0] = "pizza";
                food[1] = "hamburger";
                food[2] = "hotdog";

                List<String> food2 = new List<String>();

                food2.Add("pizza");
                food2.Add("soda");
                food2.Add("fries");
                food2.Add("potatoes");
                food2.Remove("potatoes");
                food2.Insert(0, "Sushi");
                Console.Write("Is there potatoes in food2 list?: " + food2.Contains("potatoes"));
                // food2.Sort();
                // food2.Reverse(); // Inverts List
                // food2.Clear();
                String[] food2Array = food2.ToArray();
                Console.WriteLine("\nFor i in list:\n");
                foreach (String c in food2)
                    { Console.WriteLine(c); }
                Console.WriteLine("\nFor i in Arraylist:\n");
                foreach (String c in food2Array)
                { Console.WriteLine(c); }

                Console.WriteLine("\nFim da aula 6.\n");
            }// END IF
            //  Class 6 END         ===================================================
        }
    }
}
               