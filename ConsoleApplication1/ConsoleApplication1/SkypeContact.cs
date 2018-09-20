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
    public class SkypeContact : AbstractCLS, IFileManager
    {
        public ArrayList arr = new ArrayList();
        private string skype;
        public SkypeContact()
        {
            this.name = "owner";
            this.skype = "SkypeName";
        }
        public SkypeContact(string Name, string skype)
        {
            this.Name = Name;
            this.skype = skype;
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
         
            foreach (SkypeContact s in arr)
            {
                Container.d.Add(s.Name,s.skype);
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
                    arr.Add(new SkypeContact(st[1], st[0]));
                }
            }
        }
        public void streamInFile(string name)
        {
            using (StreamWriter writer = File.CreateText(name))
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if(arr[i] is SkypeContact)
                    writer.WriteLine(arr[i]);

                    ////writer.Write(writer.NewLine);
                }
            }
        }
        public override string ToString()
        {
            return "Name: " +  Name  + " Skype: " + skype;
        }
    }
}
