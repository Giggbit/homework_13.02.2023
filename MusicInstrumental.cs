using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    abstract internal class MusicInstrumental
    {
        private string name;
        private string description;

        public MusicInstrumental() { }
        public MusicInstrumental(string name, string description) {
            this.name = name;   
            this.description = description;
        }

        public abstract void Sound();
        public virtual void Show() {
            Console.WriteLine($"Instrument: {name}");
        }
        public virtual void Desc() {
            Console.WriteLine($"Desc: {description}");
        }
        public abstract void History();


    }
}
