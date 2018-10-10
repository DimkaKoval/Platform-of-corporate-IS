using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
   public class Container
    {
        static public Dictionary<string, string> d = new Dictionary<string, string>();
        static public Dictionary<string, string> d1 = new Dictionary<string, string>();

        static public void printDictionaryToFile(string name)
        {
            using (StreamWriter writer = File.CreateText(name))
            {
                foreach (KeyValuePair<string, string> kvp in d)
                {
                    writer.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }

                writer.WriteLine("     Users only with phone number");
                foreach (KeyValuePair<string, string> kvp in d1)
                {
                    writer.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
