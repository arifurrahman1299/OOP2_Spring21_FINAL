using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Md = new Savings("Md", "1111", 10000.0f);
            Account Tanvir = new Current("Tanvir", "1112", 5000f);
            Account Ahmed = new Fixed("Ahmed", "1113", 3000f, 2015, 10);

            Account ss = new SuperSavings("Arifur", "1114", 5000f);
            ss.Withdraw(500);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Rahman", "1115", 1000f, 2000);
            overdraft.Transfer(ss, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Arifur Rahman");

        }
    }
}