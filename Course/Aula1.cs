using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    static class Aula1
    {
        // ======================================
        public static void slashEnemy(string TARGET)
        {
            Console.WriteLine("Slashes " + TARGET);
        }

        // ======================================
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        // ======================================
        public static int DamageCalculator(params double[] damages)
        {
            double total_damage = 0;

            foreach (double damage in damages)
            {
                total_damage += damage;
            }

            return (int)total_damage;
        }
        //  Class 1 END         ===================================================
    }
}
