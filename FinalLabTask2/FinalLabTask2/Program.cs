using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask2
{
    class Program
    {
        Account a1 = new Account("Arifur", "1111", 15000.0f);
        Account a2 = new Account("Rahman", "1112", 10000.0f);

        Transaction t = new Transaction(a1, a2, 100);


    }
}