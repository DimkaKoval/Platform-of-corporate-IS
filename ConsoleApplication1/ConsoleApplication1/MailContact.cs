using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApplication1;
using System.IO;

namespace ConsoleApplication1
{
    public class MailContact : AbstractCLS, IFileManager
    {
        public ArrayList arr = new ArrayList();
        private string mail;
        public MailContact()
        {
            this.name = "owner";
            this.mail = "@gmail.com";
        }
        public MailContact(string Name, string mail)
        {
            this.Name = Name;
            this.mail = mail;
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
   
        public override void moveToDictionary()
        {
            foreach (MailContact m in arr)
            {
                Container.d.Add(m.Name, m.mail);
            }

        }
        public void readFromFile(string name)
        {
            using (StreamReader sr = File.OpenText(name))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] st = line.Split(' ');
                    arr.Add(new MailContact(st[1], st[0]));
                }
            }
        }

        public void streamInFile(string name)
        {
            using (StreamWriter writer = File.CreateText(name))
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] is MailContact)
                        writer.WriteLine(arr[i]);

                    writer.Write(writer.NewLine);
                }
            }
        }
        public override string ToString()
        {
            return "Name: " + Name + " Mail: " + mail;
        }
    }
}
