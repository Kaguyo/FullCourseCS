using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course.Interfaces
{
    interface IEletrodomestico
    {
        virtual void Ligar() 
        {
            Console.WriteLine("O dispositivo está ligado");
        }
    }
}