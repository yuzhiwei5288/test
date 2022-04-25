using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoledemo1st
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            #region 测试折叠代码
            Console.WriteLine(GetString(1));
            Console.ReadKey();
            #endregion
        }

        static string GetString(int a)
        {
            uint b = 1;
            b += 1;
            int c = (int)b;
            // dev分支
            // 5288
            string tt = "5288";
            // 测试小乌龟
            // 520提交
            string ss = "520";
            // 测试一发
            // ss修改代码
            string st = "ss修改st代码";

            // ss添加新代码
            string ssadd = "ssadd";

            Console.WriteLine(b);
            return "a" + a;
        }


    }
}