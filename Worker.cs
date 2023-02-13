using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    abstract internal class Worker
    {
        private string proff;

        public Worker() { }
        public Worker(string proff) {
            this.proff = proff;
        }

        public virtual void Print() {
            Console.WriteLine($"Proffesional: {proff}");
        }
    }
}
