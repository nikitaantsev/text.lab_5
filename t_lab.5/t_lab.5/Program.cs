using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace t_lab._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(fact(n));
            Console.ReadLine();
        }
        static BigInteger fact(BigInteger num)
        {
            return (num == 0) ? 1 : num * fact(num - 1);
        }

    }

}
