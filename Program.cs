using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static int PrintMenu() {
            bool valid = true;
            int option = 0;
            while (valid) {
                Console.WriteLine("Please select one of the following option (1-7)");
                Console.WriteLine("1 - Get Rectangle length.");
                Console.WriteLine("2 - Change Rectangle length.");
                Console.WriteLine("3 - Get Rectangle width.");
                Console.WriteLine("4 - Change Rectangle width.");
                Console.WriteLine("5 - Get Rectangle Perimeter.");
                Console.WriteLine("6 - Get Rectangle Area.");
                Console.WriteLine("7 - Exit");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option > 0 && option <= 7)
                        valid = false;
                }
                catch
                {
                    valid = true;
                }
            }
            return option;
        }
        static int InputLength() {
            bool valid = true;
            int length = 0;
            while (valid) {
                Console.WriteLine("Please input the length of the rectangle (numeric value): ");
                try {
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length < 0)
                    {
                        Console.WriteLine("The length should be greater than 0.");
                    }
                    else
                    {
                        valid = false;
                    }
                }
                catch{ valid = true; }
            }
            return length;
        }
        static int InputWidth()
        {
            bool valid = true;
            int width = 0;
            while (valid)
            {
                Console.WriteLine("Please input the width of the rectangle (numeric value): ");
                try
                {
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width < 0) {
                        Console.WriteLine("The width should be greater than 0.");
                    }
                    else
                    {
                        valid = false;
                    }   
                }
                catch { valid = true; }
            }
            return width;
        }
        static void Main(string[] args)
        {
            int length = InputLength();
            int width = InputWidth();
            Rectangle rectangle = new Rectangle(width, length);
            int option = 0;
            while (option != 7) {
                option = PrintMenu();
                switch (option) {
                    case 1:
                        int _length = rectangle.GetLength();
                        Console.WriteLine("The length of the rectangle is :"+_length);
                        break;
                    case 2:
                        
                        int new_length = InputLength();
                        Console.WriteLine("The new length of the rectangle is : "+rectangle.SetLength(new_length));
                        break;
                    case 3:
                        int _width = rectangle.GetWidth();
                        Console.WriteLine("The width of the rectangle is :" + _width);
                        break;
                    case 4:
                        int new_width = InputWidth();
                        Console.WriteLine("The new length of the rectangle is : " + rectangle.SetLength(new_width));
                        break;
                    case 5:
                        int perimeter = rectangle.GetPerimeter();
                        Console.WriteLine("The Perimeter of the rectangle is :" + perimeter);
                        break;
                    case 6:
                        int area = rectangle.GetArea();
                        Console.WriteLine("The Area of the rectangle is :" + area);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
