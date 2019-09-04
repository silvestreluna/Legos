﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.MiniFigures.Parts
{
    class YetiTorso : Torso
    {
        public override bool ChestHair => true;

        public YetiTorso()
        {
            HandType = HandType.None;
            Shirt = "None";
            NumberOfArms = 2;
        }

        public void Flex()
        {
            Console.WriteLine("The Yeti torso menacingly with no hands.");
        }

        public void Fight()
        {
            Console.WriteLine("The yeti torso smacks you with his nubs.");
        }
    }
}
