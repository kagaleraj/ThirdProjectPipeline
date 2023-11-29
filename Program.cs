using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProjectPipeline
{
    internal class Program
    {
        public void Mul()
        {
            int a, b, c;
            a = 5;
            b = 5;
            c = a * b;
            Console.WriteLine("Mul=" + c);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Mul();
            Console.ReadLine();
        }
    }
}
