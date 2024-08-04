﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course.Interfaces
{
    interface IArcher
    {
        virtual void RangeAttack() 
        {
            Console.WriteLine("Ataque de longe");
        }
    }
    public interface ISaber
    {
        virtual void SwordSkill() 
        {
            Console.WriteLine("Ataque de espada");
        }
    }
    interface IAssassin
    {
        virtual void MurderSkill()
        {
            Console.WriteLine("Habilidade Assassin");
        }
    }
}
