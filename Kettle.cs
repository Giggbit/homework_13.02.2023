﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    internal class Kettle : Device
    {
        public Kettle() { }
        public Kettle(string name, string character) : base(name, character) { }

        public override void Sound() {
            Console.WriteLine("Ppsshhhhhh");
        }
    }
}
