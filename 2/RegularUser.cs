using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class RegularUser : User 
    {
        public void PostComment()
        {
            Console.WriteLine("Коментар опубліковано.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Звичайний користувач");
        }
    }
}