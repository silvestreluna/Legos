using Legos.MiniFigures;
using Legos.MiniFigures.Parts;
using System;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var miniFigure = new MiniFigure();
            miniFigure.Head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3,
            };

            var fatHead = new FatHead();
            fatHead.Talk();
            miniFigure.Head.Think();

            switch (miniFigure.Head)
            {
                case YodaHead h:
                    h.Battle();
                    break;
            }

            //fatHead.Size = HeadSize.Small;
        }
    }
}
