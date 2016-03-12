using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    public class Reflection
    {
        public void ColorPrint(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] propInfo = t.GetProperties();
            foreach (PropertyInfo prop in propInfo)
            {
                if (prop.IsDefined(typeof(ColorAttributes)))
                {
                    ColorAttributes a = (ColorAttributes)prop.GetCustomAttribute(typeof(ColorAttributes));
                    Console.BackgroundColor = a.Color;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(prop.GetValue(o));
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(prop.GetValue(o));
                }
            }
        }
    }
}
