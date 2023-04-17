using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public readonly struct Position
    {
        public int Top { get; }
        public int Left { get; }
        public Position(int top, int left)
        {
            Top = top <= -1 ? 0 : top;
            Left = left <= -1 ? 0 : left;
        }

        public Position RightBy(int n) => new(Top, Left + n);
        public Position DownBy(int n) => new(Top + n, Left);
    }
}
