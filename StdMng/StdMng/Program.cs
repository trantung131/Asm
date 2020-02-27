using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdMng
{
    class Program
    {
        public static List<Student> list = new List<Student>();
        public static List<Lecture> listLecture = new List<Lecture>();
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            int Select;
            do
            {
                Console.WriteLine();
                Console.WriteLine("*--------------------------------------*");
                Console.WriteLine("*Welcome to Student Management Software*");
                Console.WriteLine("*--------------------------------------*");
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. Lesson Plan Management");
                Console.WriteLine("3. Exit");
                Console.Write("You want to select the function: ");
                Select = int.Parse(Console.ReadLine());
                switch (Select)

                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("         Management Student         ");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("1. Add new student.                 ");
                        Console.WriteLine("2. View all list student.           ");
                        Console.WriteLine("3. Search Student Information.      ");
                        Console.WriteLine("4. Delete Student.                  ");
                        Console.WriteLine("5. Update Student.                  ");
                        Console.WriteLine("6. Back to main menu.               ");
                        Console.WriteLine("------------------------------------");
                        Console.Write("You want to select the function: ");
                        Select = int.Parse(Console.ReadLine());
                        switch (Select)
                        {
                            case 1:
                                EnterListStd(); MainMenu();
                                break;
                            case 2:
                                ViewListStd(); MainMenu();
                                break;
                            case 3:
                                Search(); MainMenu();
                                break;
                            case 4:
                                Delete(); MainMenu();
                                break;
                            case 5:
                                Update(); MainMenu();
                                break;
                            case 6:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("         Lesson Plan Management     ");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("1. Add new Lecture.                 ");
                        Console.WriteLine("2. View all list Lecture.           ");
                        Console.WriteLine("3. Search Lecture.                  ");
                        Console.WriteLine("4. Delete Lecture.                  ");
                        Console.WriteLine("5. Update Lecture.                  ");
                        Console.WriteLine("6. Back to main menu.               ");
                        Console.WriteLine("------------------------------------");
                        Console.Write("You want to select the function: ");
                        Select = int.Parse(Console.ReadLine());
                        switch (Select)
                        {
                            case 1:
                                EnterListLecture();
                                break;
                            case 2:
                                ViewListLecture();
                                break;
                            case 3:
                                SearchLecture();
                                break;
                            case 4:
                                DeleteLecture();
                                break;
                            case 5:UpdateLecture();
                                break;
                            case 6:
                                break;
                        }
                        break;
                }

            } while (Select != 3);
        }
        public static void EnterListStd()
        {
            Console.Write("Enter the number of student you want to add: ");
            int NStd = int.Parse(Console.ReadLine());
            for (int i = 0; i < NStd; i++)
            {
                Student Std = new Student();
                Std.Enter();
                list.Add(Std);
            }
        }
        public static void ViewListStd()
        {
            Student.outPutHeader();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].OutPut();
            }
        }
        public static void Search()
        {
            Console.Write("Enter the student's name need to search: ");
            string FullName = Console.ReadLine();
            Student.outPutHeader();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].fullName == FullName)
                {
                    list[i].OutPut();
                }
            }
        }
        public static void Update()
        {
            Console.Write("Enter the student's ID need to update: ");
            string ID = Console.ReadLine();
           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == ID)
                {
                    list[i].Enter();
                }
            }          
            ViewListStd();
        }
        public static void Delete()
        {
            Console.Write("Enter the student's ID need to delete: ");
            string ID = Console.ReadLine();
            Student.outPutHeader();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == ID)
                {
                    list.RemoveAt(i);
                }
            }
            ViewListStd();
        }
        public static void EnterListLecture()
        {
            Console.Write("Enter the number of Lecture you want to add: ");
            int NL = int.Parse(Console.ReadLine());
            for (int i = 0; i < NL; i++)
            {
                Lecture nl = new Lecture();
                nl.Enter();
                listLecture.Add(nl);
            }
        }
        public static void ViewListLecture()
        {
            Lecture.outPutHeaderLecture();
            for (int i = 0; i < listLecture.Count; i++)
            {
                listLecture[i].OutPutLecture();
            }
        }
        public static void SearchLecture()
        {
            Console.Write("Enter the Lecture's name need to search: ");
            string FullName = Console.ReadLine();
            Lecture.outPutHeaderLecture();
            for (int i = 0; i < listLecture.Count; i++)
            {
                if (listLecture[i].fullName == FullName)
                {
                    listLecture[i].OutPutLecture();
                }
            }
        }
        public static void UpdateLecture()
        {
            Console.Write("Enter the Lecture's ID need to update: ");
            string ID = Console.ReadLine();
            Lecture.outPutHeaderLecture();
            for (int i = 0; i < list.Count; i++)
            {
                if (listLecture[i].id == ID)
                {
                    listLecture[i].OutPutLecture();
                }
            }
            Lecture.outPutHeaderLecture();
            ViewListLecture();
        }
        public static void DeleteLecture()
        {
            Console.Write("Enter the Lecture's ID need to delete: ");
            string ID = Console.ReadLine();
            Lecture.outPutHeaderLecture();
            for (int i = 0; i < listLecture.Count; i++)
            {
                if (listLecture[i].id == ID)
                {
                    listLecture.RemoveAt(i);
                }
            }
            ViewListLecture();
        }
    }
}
