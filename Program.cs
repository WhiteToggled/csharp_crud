using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using LmsApp.Menus;

namespace LmsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.display();
            Thread.Sleep(1);
        }
    }
}

/*                case 1:*/
/*                    Console.WriteLine("1. Add StudentEnter RegNo: ");*/
/*                    regNo = Console.ReadLine();*/
/*                    Console.WriteLine("Enter Name: ");*/
/*                    name = Console.ReadLine();*/
/*                    Console.WriteLine("Enter Department: ");*/
/*                    department = Console.ReadLine();*/
/*                    Console.WriteLine("Enter Session: ");*/
/*                    session = Convert.ToInt32(Console.ReadLine());*/
/*                    Console.WriteLine("Enter CGPA: ");*/
/*                    cgpa = Convert.ToSingle(Console.ReadLine());*/
/*                    Console.WriteLine("Enter Address: ");*/
/*                    address = Console.ReadLine();*/
/**/
/*                    student = new Student(regNo, name, department, session, cgpa, address);*/
/*                    student.AddStudent();*/
/*                    break;*/
/*                case 2:*/
/*                    Console.WriteLine("Enter RegNo: ");*/
/*                    regNo = Console.ReadLine();*/
/*                    Console.WriteLine("Enter Name: ");*/
/*                    name = Console.ReadLine();*/
/*                    Console.WriteLine("Enter CGPA: ");*/
/*                    cgpa = Convert.ToSingle(Console.ReadLine());*/
/**/
/*                    student = new Student(regNo, name, cgpa: cgpa);*/
/*                    student.EditStudent();*/
/*                    break;*/
/*                case 3:*/
/*                    Console.WriteLine("Enter RegNo: ");*/
/*                    regNo = Console.ReadLine();*/
/**/
/*                    student = new Student(regNo);*/
/*                    student.DeleteStudent();*/
/*                    break;*/
/*                case 4:*/
/*                    Console.WriteLine("Enter RegNo: ");*/
/*                    regNo = Console.ReadLine();*/
/**/
/*                    student = new Student(regNo);*/
/*                    student.SearchStudent();*/
/*                    break;*/
/*                case 5:*/
/*                    student = new Student(null);*/
/*                    student.ShowStudents();*/
/*                    break;*/
/*                default:*/
/*                    Console.WriteLine("Invalid choice");*/
/*                    break;*/
/*            }*/
/*            Console.ReadKey();*/
/*            choice = Menus.StudentMenu();*/
/*        }*/
/**/
/*    }*/
/*}*/
