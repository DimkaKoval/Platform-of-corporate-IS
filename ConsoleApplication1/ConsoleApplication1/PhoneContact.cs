using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApplication1;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    public class PhoneContact : AbstractCLS, IFileManager
    {
        public ArrayList arr = new ArrayList();
        private string phoneNumber;
        /// <summary>
        /// The class method creates an instance of the class for typing 
        /// </summary>
        public PhoneContact()
        {
            this.name = "owner";
            this.phoneNumber = "+380662541248";
        }
        /// <summary>
        /// The class method creates an instance of a class with parameters
        /// </summary>
        /// <param name="Name"> fill in the name field </param>
        /// <param name="skype"> fill in the phone field </param>
        public PhoneContact(string Name, string phoneNumber)
        {
            this.Name = Name;
            this.phoneNumber = phoneNumber;
        }
        /// <summary>
        /// the abstract class method returns or sets the name
        /// </summary>
        public override string Name
        {
            get {
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
            foreach (PhoneContact p in arr)
            {
                Container.d.Add(p.Name, p.phoneNumber);
                Container.d1.Add(p.Name,p.phoneNumber);
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
                    arr.Add(new PhoneContact(st[1],st[0]));                   
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
                    if (arr[i] is PhoneContact)
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
            return "Name:" + " " + Name + " " + "Phone Number: " + phoneNumber;
        }
    }
}
