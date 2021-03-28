using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int sum = cal.sum(50, 100);
            Console.WriteLine(sum);

            Scientific sc = new Scientific();
            int res = sc.XtoY(6, 3);
            Console.WriteLine(res);

        }
    }
}
