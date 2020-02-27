using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng
{
    class Lecture
    {
        private string FullName;
        private string ID;
        private string DoB;
        private string Email;
        private string Address;
        private string Dept;
        public string id { get { return ID; } set { ID = value; } }
        public string fullName { get { return FullName; } set { FullName = value; } }
        public string dob { get { return DoB; } set { DoB = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public string address { get { return Address; } set { Address = value; } }
        public string dept { get { return Dept; } set { Dept = value; } }
        public Lecture() { }
        public Lecture(string id, string fullName, string dob, string email, string address, string dept)
        {
            this.ID = id;
            this.FullName = fullName;
            this.DoB = dob;
            this.Email = email;
            this.Address = address;
            this.Dept = dept;
        }
        public void Enter()
        {
            Console.Write("Enter the Lecture' ID: ");
            this.ID = Console.ReadLine();
            Console.Write("Enter the Lecture's name: ");
            this.FullName = Console.ReadLine();
            Console.Write("Enter the Lecture' birth day: ");
            this.DoB = Console.ReadLine();
            Console.Write("Enter the Lecture's email: ");
            this.Email = Console.ReadLine();
            Console.Write("Enter the Lecture' address: ");
            this.Address = Console.ReadLine();
            Console.Write("Enter the Lecture's class: ");
            this.Dept = Console.ReadLine();
        }
        public void OutPutLecture()
        {
            string chain = string.Format("{0,20}{1,20}{2,20}{3,20}{4,20}{5,20}", this.ID, this.FullName, this.DoB, this.Email, this.Address, this.Dept);
            Console.WriteLine(chain);
        }
        public static void outPutHeaderLecture()
        {
            string chain = string.Format("{0,20}{1,20}{2,20}{3,20}{4,20}{5,20}", "The Lecture's ID", "The Lecture's name", "The Lecture's birth day", "The Lecture's Email", "The Lecture's Address", "The Lecture's class");
            Console.WriteLine(chain);
        }

    }
}


