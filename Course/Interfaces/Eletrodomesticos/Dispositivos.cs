using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course.Interfaces.Eletrodomesticos
{
    public class Dispositivos
    {
        public class Geladeira : Interfaces.IEletrodomestico
        {
            static public void Ligar()
            {
                string dispositivo = "Geladeira";
                if (dispositivo[dispositivo.Length - 1] == 'a')
                {
                    Console.WriteLine($"A {dispositivo} está ligada");
                }
                else
                {
                    Console.WriteLine($"O {dispositivo} está ligado");
                }
            }
        }
        public class MicroOndas : Interfaces.IEletrodomestico
        {
            static public void Ligar()
            {
                string dispositivo = "Micro-Ondas";
                if (dispositivo[dispositivo.Length - 1] == 'a')
                {
                    Console.WriteLine($"A {dispositivo} está ligada");
                }
                else
                {
                    Console.WriteLine($"O {dispositivo} está ligado");
                }
            }
        }
        public class Aquecedor : Interfaces.IEletrodomestico
        {
            static public void Ligar()
            {
                string dispositivo = "Aquecedor";
                if (dispositivo[dispositivo.Length - 1] == 'a')
                {
                    Console.WriteLine($"A {dispositivo} está ligada");
                }
                else
                {
                    Console.WriteLine($"O {dispositivo} está ligado");
                }
            }
        }
    }
}
