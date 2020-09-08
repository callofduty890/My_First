using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS19_My_First
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出
            Console.WriteLine("这是我的第一个程序!");
            //占位符
            Console.WriteLine("这是我的第{0}个程序!", "二");
            Console.WriteLine("这是我的第{0}个程序!,我感觉{1}", "二","非常好");
            Console.ReadKey();
        }

    }
}
