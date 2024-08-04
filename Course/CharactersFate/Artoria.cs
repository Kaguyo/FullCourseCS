using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FullCourseCS.Course.CharactersFate
{
    internal class Artoria : FullCourseCS.Course.Interfaces.ISaber
    {
        public String name = "Artoria";
        private static Random random = new Random();
        public void SwordSkill()
        {
            Console.Write($"{name}: ");
            int choice = random.Next(1, 5);

            switch (choice)
            {
                case 1:
                    PerformComment1();
                    break;
                case 2:
                    PerformComment2();
                    break;
                case 3:
                    PerformComment3();
                    break;
                case 4:
                    PerformComment4();
                    break;
            }
        }
        public void Excalibur()
        {
            Console.Write($"{name}: ");
        }
        private void PerformComment1()
        {
            string comment = "Leave it to me.";
            foreach (char c in comment)
            {
                Console.Write(c);
                Thread.Sleep(0010); // Meio milissegundo de pausa por caractere
            }
            Console.WriteLine(); // Para adicionar uma nova linha após o comentário
            Console.ReadKey();
        }
        private void PerformComment2()
        {
            string comment = "Hahh!";
            foreach (char c in comment)
            {
                Console.Write(c);
                Thread.Sleep(0010); // Meio milissegundo de pausa por caractere
            }
            Console.WriteLine(); // Para adicionar uma nova linha após o comentário
            Console.ReadKey();
        }
        private void PerformComment3()
        {
            string comment = "I'll cut them down!";
            foreach (char c in comment)
            {
                Console.Write(c);
                Thread.Sleep(0010); // Meio milissegundo de pausa por caractere
            }
            Console.WriteLine(); // Para adicionar uma nova linha após o comentário
            Console.ReadKey();
        }
        private void PerformComment4()
        {
            string comment = "There's still more!";
            foreach (char c in comment)
            {
                Console.Write(c);
                Thread.Sleep(0010); // Meio milissegundo de pausa por caractere
            }
            Console.WriteLine(); // Para adicionar uma nova linha após o comentário
            Console.ReadKey();
        }
    }
}