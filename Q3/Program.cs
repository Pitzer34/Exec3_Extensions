using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    //針對 string 寫一個擴充方法 ToInt(this string value, int defaultValue),
    //可以將 string 轉換成 int 型別, 如果無法轉型成功, 傳回 defaultValue

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class ToIntCls
    {
        public static int ToInt(this string value, int defaultValue)
        {
            bool ISINT = int.TryParse(value, out int result);
            
            if (ISINT == false)
            {
                return defaultValue;
            }
            return result;
        }
    }
}
