using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection.cContacts.Add(new PhoneContact("Ivan", "+380589872536"));
            foreach(var t in Collection.cContacts)
            {
                Console.WriteLine(t.ToString());
            }
            PhoneContact p = new PhoneContact();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
