using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflection r = new Reflection();   
            Rainbow rainbow = new Rainbow("Каждый    ", "Охотник   ", "Желает    ", "Знать     ", "Где       ", "Сидит     ", "Фазан     ");
            string flagLenth = "                                ";
            Flags flags = new Flags("Украина", "Россия", "Люксембург", "Сьерра-Леоне", "Нидерланды", flagLenth);
            r.ColorPrint(rainbow);
            r.ColorPrint(flags);
        }
    }
}
