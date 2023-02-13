using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    internal class Trombon : MusicInstrumental
    {
        public Trombon() { }
        public Trombon(string name, string description) : base(name, description){ }

        public override void Sound() {
            Console.WriteLine("Tromb tromb");
        }
        public override void Show() {
            base.Show();
        }
        public override void Desc() {
            base.Desc();
        }
        public override void History() {
            Console.Write($"Enter history about this instrument: ");
            string about = Console.ReadLine();
        }
    }
}
