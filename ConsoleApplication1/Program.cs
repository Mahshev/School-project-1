using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char k; 
            Console.WriteLine("Pls type a character.");
            k = char.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("  " + k);
            Console.Write(" " + k); Console.WriteLine(k);
            Console.Write(k); Console.Write(k); Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
