using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    internal class Vialanchel : MusicInstrumental
    {
        public Vialanchel() { }
        public Vialanchel(string name, string description) : base(name, description){ }

        public override void Sound() {
            Console.WriteLine("vi a la nchel");
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
