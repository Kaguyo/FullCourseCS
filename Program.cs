using System;

namespace FullCourseCS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAula1 = true;
            if (playAula1)
            {
                String target = "Enemy";
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

                String[,] personagens = { {"TrailBlazer", "Danheng","March7th","Asta", "Himeko", "Welt", "Herta", "Arlan"},
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
            }// END IF
            Console.WriteLine("\nFim da aula 1.\n");
            //  Class 1 END         ===================================================
            Characters Naruto = new Characters();
            Naruto.name = "Naruto Uzumaki";
            Naruto.age = 15;
            Naruto.Introduce();
           
            Car car1 = new Car("Ford", "Fusion", 2019, "Black");
            car1.Drive();
        }        
    }
}
