using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    
    public class Rainbow
    {
        public string RainbowWord { get; set; }
        [ColorAttributes(ConsoleColor.Red)]
        public string Red { get; set; }
        [ColorAttributes(ConsoleColor.Yellow)]
        public string Orange { get; set; }
        [ColorAttributes(ConsoleColor.Yellow)]
        public string Yellow { get; set; }
        [ColorAttributes(ConsoleColor.Green)]
        public string Green { get; set; }
        [ColorAttributes(ConsoleColor.Blue)]
        public string Blue { get; set; }
        [ColorAttributes(ConsoleColor.Cyan)]
        public string Cyan { get; set; }
        [ColorAttributes(ConsoleColor.DarkMagenta)]
        public string Purple { get; set; }

        public Rainbow(string red, string orange, string yellow, string green, string blue, string cyan, string purpule)
        {
            RainbowWord = "Радуга";
            Red = red;
            Orange = orange;
            Yellow = yellow;
            Green = green;
            Blue = blue;
            Cyan = cyan;
            Purple = purpule;
            
        }
    }
}
