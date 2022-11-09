using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32_IsOdd_IsEven
{
    //IsOdd()傳回 bool , 表示是否為奇數
    //IsEven()傳回 bool , 表示是否為偶數

    internal class Program
    {
        static void Main(string[] args)
        {
        }

    }
    
    public static class OddEven
    {
        public static bool IsOdd(this int number)
        {
            return (number % 2 == 0);
        }
        public static bool IsEven(this int number)
        {
            return (number % 2 == 1);
        }
    }
}
