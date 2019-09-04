﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.MiniFigures.Parts
{
    class DarthVedeHead : Head
    {
        public override void Talk()
        {
            Console.WriteLine("KHOOOOH PUUUHRR");
            base.Talk();
            Console.WriteLine("KHOOOOH PUUUHRR");
        }
        public override void Think()
        {
            Console.WriteLine("Am I your father?");
        }
    }
}
