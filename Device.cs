using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    abstract internal class Device
    {
        private string name;
        private string character;

        public Device() { }
        public Device(string name, string character) { 
            this.name = name;
            this.character = character;
        }

        public abstract void Sound();
        public virtual void Show() {
            Console.WriteLine($"Name: {name}");
        }
        public virtual void Desc() { 
            Console.WriteLine($"Character :{character}");
        }
    }
}
