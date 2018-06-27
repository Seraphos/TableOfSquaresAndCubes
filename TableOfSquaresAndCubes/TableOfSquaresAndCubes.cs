using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfSquaresAndCubes
{
    class TableOfSquaresAndCubes
    {
        static void Main(string[] args)
        {
            int zero, one, two, three, four, five, six, seven, eight, nine, ten;
            zero = 0; one = 1; two = 2; three = 3; four = 4; five = 5; six = 6; seven = 7; eight = 8; nine = 9; ten = 10;
            Console.WriteLine("\tNumber\t\tSquare\t\tCube");
            Console.WriteLine("\t{0}\t \t{0}\t \t{0}", zero);
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", one, Math.Pow(one, 2), Math.Pow(one, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", two, Math.Pow(two, 2), Math.Pow(two, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", three, Math.Pow(three, 2), Math.Pow(three, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", four, Math.Pow(four, 2), Math.Pow(four, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", five, Math.Pow(five, 2), Math.Pow(five, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", six, Math.Pow(six, 2), Math.Pow(six, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", seven, Math.Pow(seven, 2), Math.Pow(seven, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", eight, Math.Pow(eight, 2), Math.Pow(eight, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", nine, Math.Pow(nine, 2), Math.Pow(nine, 3));
            Console.WriteLine("\t{0}\t \t{1}\t \t{2}", ten, Math.Pow(ten, 2), Math.Pow(ten, 3)); 

        }
    }
}
