using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColorAttributes : System.Attribute
    {
        public ConsoleColor Color { get; set; }

        public ColorAttributes()
        { }
        public ColorAttributes(ConsoleColor c)
        {
            Color = c;
        }
    }
}
