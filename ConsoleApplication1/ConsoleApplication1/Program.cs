using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication1
{

    abstract public class AbstractCLS
    {
        protected string name;
       abstract public string Name { get; set; }
       abstract public void moveToDictionary();
        
   
    }
    /// <summary>
    ///  class interface has methods of working with files
    /// </summary>
    interface IFileManager
    {
        void readFromFile(string name);
        void streamInFile(string name);
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            
            MailContact m = new MailContact();
            m.readFromFile("MailText.txt");
            m.streamInFile("MST.txt");
            Console.WriteLine(m);
          

            SkypeContact s = new SkypeContact();
            s.readFromFile("SkypeText.txt");            
            s.streamInFile("SST.txt");
            Console.WriteLine(s);
        

            PhoneContact p = new PhoneContact();
            p.readFromFile("PhoneText.txt");
            p.streamInFile("PST.txt");
            Console.WriteLine(p);

            m.moveToDictionary();
            s.moveToDictionary();
            p.moveToDictionary();

            Container.printDictionaryToFile("Contacts.txt");

    

            Console.ReadLine();
        }
    }
}
