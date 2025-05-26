using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Moderator : User
    {
        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Модератор");
        }
    }
}