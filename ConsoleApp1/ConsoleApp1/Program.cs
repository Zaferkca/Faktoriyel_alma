using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class fakto
    {
        public int Kdf(int say1)
        {
            int toplam = 1;
            for(int i = 1; i <= say1; i++)
            {
                toplam = toplam * i;
            }
            return toplam;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            fakto fakto= new fakto();
            Console.WriteLine("sayınızı giriniz");
            int say1=Convert.ToInt32(Console.ReadLine());
            int toplam=fakto.Kdf(say1);
            Console.WriteLine("faktoriyeli: {0}", toplam);
            Console.ReadKey();
        }
    }
}
