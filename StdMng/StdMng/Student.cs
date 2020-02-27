using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng
{
    class Student
    {
        private string FullName;
        private string ID;
        private string DoB;
        private string Email;
        private string Address;
        private string Batch;
        public string id { get { return ID; } set { ID = value; } }
        public string fullName { get { return FullName; } set { FullName = value; } }
        public string dob { get { return DoB; } set { DoB = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public string address { get { return Address; } set { Address = value; } }
        public string batch { get { return Batch; } set { Batch = value; } }
        public Student() {}
        public Student(string id, string fullName, string dob, string email, string address, string batch)
        {
            this.ID = id;
            this.FullName = fullName;
            this.DoB = dob;
            this.Email = email;
            this.Address = address;
            this.Batch = batch;
        }
        public void Enter() 
        {
            Console.Write("Enter the student' ID: ");
            this.ID = Console.ReadLine();
            Console.Write("Enter the student's name: ");
            this.FullName = Console.ReadLine();
            Console.Write("Enter the student' birth day: ");
            this.DoB = Console.ReadLine();
            Console.Write("Enter the student's email: ");
            this.Email = Console.ReadLine();
            Console.Write("Enter the student' address: ");
            this.Address = Console.ReadLine();
            Console.Write("Enter the student's class: ");
            this.Batch = Console.ReadLine();
        }
         public void OutPut()
         {
            string chain = string.Format("{0,30}{1,30}{2,30}{3,30}{4,30}{5,30}",this.ID,this.FullName,this.DoB,this.Email,this.Address,this.Batch);
            Console.WriteLine(chain);
         }   
        public static void outPutHeader()
        {
            string chain = string.Format("{0,20}{1,20}{2,20}{3,20}{4,20}{5,20}","The Student's ID", "The Student's name", "The Student's birth day", "The Student's Email", "The Student's Address", "The Student's class");
            Console.WriteLine(chain);
        }

    }
}
