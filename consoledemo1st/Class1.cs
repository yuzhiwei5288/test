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
            // tt删除代码
            // tt添加新代码
            string tt = "添加新代码";
            string ttadd = "ttadd";
            Console.WriteLine(ttadd+tt);
            return "a" + a;
        }


    }
}