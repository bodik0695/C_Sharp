using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    class Flags
    {
        public string Ukraine { set; get; }
        [ColorAttributes(ConsoleColor.Blue)]
        public string FirstLineUkraine { set; get; }
        [ColorAttributes(ConsoleColor.Yellow)]
        public string SecondLineUkraine { set; get; }
        
        public string Russia { set; get; }
        [ColorAttributes(ConsoleColor.White)]
        public string FirstLineRussia { set; get; }
        [ColorAttributes(ConsoleColor.Blue)]
        public string SecondLineRussia { set; get; }
        [ColorAttributes(ConsoleColor.Red)]
        public string ThirdLineRussia { set; get; }
        
        public string Luxembourg { set; get; }
        [ColorAttributes(ConsoleColor.Red)]
        public string FirstLineLuxembourg { set; get; }
        [ColorAttributes(ConsoleColor.White)]
        public string SecondLineLuxembourg { set; get; }
        [ColorAttributes(ConsoleColor.Cyan)]
        public string ThirdLineLuxembourg { set; get; }
        
        public string SierraLeone { set; get; }
        [ColorAttributes(ConsoleColor.Green)]
        public string FirstLineSierraLeone { set; get; }
        [ColorAttributes(ConsoleColor.White)]
        public string SecondLineSierraLeone { set; get; }
        [ColorAttributes(ConsoleColor.Cyan)]
        public string ThirdLineSierraLeone { set; get; }
        
        public string Netherlands { set; get; }
        [ColorAttributes(ConsoleColor.Red)]
        public string FirstLineNetherlands { set; get; }
        [ColorAttributes(ConsoleColor.White)]
        public string SecondLineNetherlands { set; get; }
        [ColorAttributes(ConsoleColor.Blue)]
        public string ThirdLineNetherlands { set; get; }

        public Flags(string ukraine, string russia, string luxembourg, string sierraLeone, string netherlands, string lenthFlag)
        {
            Ukraine = ukraine;
            FirstLineUkraine = lenthFlag;
            SecondLineUkraine = lenthFlag;

            Russia = russia;
            FirstLineRussia = lenthFlag;
            SecondLineRussia = lenthFlag;
            ThirdLineRussia = lenthFlag;

            Luxembourg = luxembourg;
            FirstLineLuxembourg = lenthFlag;
            SecondLineLuxembourg = lenthFlag;
            ThirdLineLuxembourg = lenthFlag;

            SierraLeone = sierraLeone;
            FirstLineSierraLeone = lenthFlag;
            SecondLineSierraLeone = lenthFlag;
            ThirdLineSierraLeone = lenthFlag;

            Netherlands = netherlands;
            FirstLineNetherlands = lenthFlag;
            SecondLineNetherlands = lenthFlag;
            ThirdLineNetherlands = lenthFlag;
        }
    }
}
