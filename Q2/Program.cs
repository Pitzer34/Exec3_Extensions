using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Left_int_length
{
    //傳回字串的前面幾個字
    //若value 是 null or empty, 都傳回 空字串
    //若 length <= 0, 傳回空字串
    //若value長度比length少, 傳回value

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class strCheck
    {
        public static string strMethod(this string value, int length)
        {
            if (string.IsNullOrEmpty(value))
            {
                return (string.Empty);
            }
            if (length <= 0)
            {
                return (string.Empty);
            }
            if (value.Length < length)
            {
                return (value);
            }

            return (value.Substring(0,length));
        }
    }
}
