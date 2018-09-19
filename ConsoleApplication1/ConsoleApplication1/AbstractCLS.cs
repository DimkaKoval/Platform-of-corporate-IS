using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    abstract public class AbstractCLS
    {
        protected string name;
        abstract public string Name();
    }
    interface IFileManager
    {
        void readFromFile();
        void streamInFile();
    }
    public class PhoneContact : AbstractCLS, IFileManager, IComparable
    {
        private string phoneNumber;
        public PhoneContact()
        {
            this.name = "owner";
            this.phoneNumber = "+380662541248";
        }

        public PhoneContact(string _name, string _pNumber)
        {
            this.name = (_name != " ") ? _name : "Owner";
            this.phoneNumber = (_pNumber != " ") ? _pNumber : "+380682134589";
        }

        public int CompareTo(object obj)
        {
            return name.CompareTo(obj);//?
        }

        public override string Name()
        {
            return name;
        }

        public void readFromFile()
        {
            throw new NotImplementedException();
        }

        public void streamInFile()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Name: " + name + " Phone Number: " + phoneNumber;
        }
    }
    public class MailContact : AbstractCLS, IFileManager
    {
        private string Mail;
        public MailContact()
        {
            this.name = "owner";
            this.Mail = "owner@gmail.com";
        }

        public override string Name()
        {
            return name;
        }
        public void readFromFile()
        {
            throw new NotImplementedException();
        }

        public void streamInFile()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Name: " + name + " Mail: " + Mail;
        }
    }
    public class SkypeContact : AbstractCLS, IFileManager
    {
        private string Skype;
        public SkypeContact()
        {
            this.name = "owner";
            this.Skype = "SkypeName";
        }

        public override string Name()
        {
            return name;
        }
        public void readFromFile()
        {
            throw new NotImplementedException();
        }

        public void streamInFile()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Name: " + name + " Skype name: " + Skype;
        }
    }
}
