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
        /// <summary>
        /// The class method creates an instance of the class for typing
        /// </summary>
        public MailContact()
        {
            this.name = "owner";
            this.mail = "@gmail.com";
        }
        /// <summary>
        /// The class method creates an instance of a class with parameters
        /// </summary>
        /// <param name="Name"> fill in the name field </param>
        /// <param name="skype"> fill in the mail field </param>
        public MailContact(string Name, string mail)
        {
            this.Name = Name;
            this.mail = mail;
        }
        /// <summary>
        /// the abstract class method returns or sets the name
        /// </summary>
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
        /// <summary>
        /// adds instances to the collection
        /// </summary>
        public override void moveToDictionary()
        {
            foreach (MailContact m in arr)
            {
                Container.d.Add(m.Name, m.mail);
            }

        }
        /// <summary>
        /// file read method
        /// </summary>
        /// <param name="name"> specify the file name </param>
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
        /// <summary>
        /// method of writing to a file
        /// </ summary>
        /// <param name = "name"> set the filename </ param>
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
        /// <summary>
        /// output method to console
        /// </ summary>
        /// <returns> </ returns>
        public override string ToString()
        {
            return "Name: " + Name + " Mail: " + mail;
        }
    }
}
