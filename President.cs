using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_в.NET_homework_13._02._2023
{
    internal class President : Worker
    {
        public President() { }
        public President(string proff) : base(proff) { }

        public override void Print() {
            base.Print();
        }
    }
}
