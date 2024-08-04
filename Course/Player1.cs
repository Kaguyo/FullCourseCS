using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourseCS.Course
{
    public class Player1
    {
        public string itemName;

        // Constructor that accepts a string parameter
        public Player1(string itemName)
        {
            this.itemName = itemName;
        }
        public static void UpgradeItem(Player1 item, string itemName)
        {
            //  Substitui um nome por um novo nome que for passado no parametro
            item.itemName = itemName;
        }
    }

}