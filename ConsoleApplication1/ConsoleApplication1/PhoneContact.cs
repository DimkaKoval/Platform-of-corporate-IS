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
    public class PhoneContact : AbstractCLS, IFileManager
    {
        public ArrayList arr = new ArrayList();
        private string phoneNumber;
        public PhoneContact()
        {
            this.name = "owner";
            this.phoneNumber = "+380662541248";
        }
        public PhoneContact(string Name, string phoneNumber)
        {
            this.Name = Name;
            this.phoneNumber = phoneNumber;
        }
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
        
        public override void moveToDictionary()
        {
            foreach (PhoneContact p in arr)
            {
                Container.d.Add(p.Name, p.phoneNumber);
                Container.d1.Add(p.Name,p.phoneNumber);
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
                    arr.Add(new PhoneContact(st[1],st[0]));                   
                }
            }
        } 
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

        public override string ToString()
        {
            return "Name: " + Name + " Phone Number: " + phoneNumber;
        }
    }
}
