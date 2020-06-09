using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Rectangle
    {
        private int width;
        private int length;

        public Rectangle() { }
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public int GetLength() { return this.length; }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth() { return this.width; }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return (2 * this.length) + (2 * this.width);
        }
        public int GetArea()
        {
            return this.length * this.width;
        }
    }
}
