using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Registration
{

    // You do NOT need to touch this file, as everything is complete.
    // You will need to complete the methods in the RegistrationDataAccess class
    // to complete the lab

    class Lab06Registration
    {
        static void Main(string[] args)
        {
            // data for the Students table in the database

            Student[] students = new Student[]
            {
                new Student("Svetlana", "Rostov", 1, 1),
                new Student("Claire",  "Bloome", 2, 2),
                new Student("Sven", "Baertschi", 3, 3),
                new Student("Cesar", "Chavez", 4, 4),
                new Student("Debra", "Manning", 5, 1),
                new Student("Fadi",  "Hadari", 6, 2),
                new Student("Hanying", "Fen", 7, 3),
                new Student("Hugo", "Victor", 8, 1),
                new Student("Lance", "Armstrong", 9, 3),
                new Student("Terry", "Matthews", 10, 1),
                new Student("Eugene", "Fei", 11, 4),
                new Student("Michael", "Thorson", 12, 1)
            };

            // departments data

            Department[] departments = new Department[]
            {
                new Department("Computing Studies", "CSIS", 1),
                new Department("Accounting", "ACCT", 2),
                new Department("Marketing", "MKTG", 3),
                new Department("Finance", "FINC", 4)
            };

            // You will use each array to populate the database
            // but you will need to query the database for each table
            // and return a list

            List<Student> studentList;
            List<Department> departmentList;

            // create a new regi DB access object
            // open the connection to the database

            RegistrationDataAccess registrationDB = new RegistrationDataAccess();
            registrationDB.OpenConnection();

            // make sure all of the tables are empty

            registrationDB.TruncateData("Students");
            registrationDB.TruncateData("Departments");

            // Insert each student into the database

            foreach (Student s in students)
            {
                registrationDB.InsertStudent(s);
            }

            // Insert each department into the database

            foreach (Department d in departments)
            {
                registrationDB.InsertDepartment(d);
            }

            // now get the tables, and store them in a List

            studentList = registrationDB.GetStudents();


            Console.WriteLine("Students table data");

            foreach (Student s in studentList)
                Console.WriteLine(s);

            departmentList = registrationDB.GetDepartments();
            foreach (Department d in departmentList)
            {
                registrationDB.GetNumberOfStudentsInMajor(d);
            }

            // EXTRA CREDIT: instead of the above in C#, use SQL statement to count 
            // number of students 

            // departmentList = registrationDB.GetNumberOfStudentsInMajor();

            Console.WriteLine("---------------\n");
            Console.WriteLine("Departments table data");

            foreach (Department d in departmentList)
                Console.WriteLine(d);

            Console.ReadLine();
            registrationDB.CloseConnection();

        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentLastName { get; set; }
        public string StudentFirstName { get; set; }
        public int StudentMajor { get; set; }

        public Student(string lastName, string firstName, int id = 0, int major = 0)
        {
            StudentFirstName = firstName;
            StudentLastName = lastName;
            StudentId = id;
            StudentMajor = major;
        }
        public override string ToString()
        {
            return string.Format($"#{StudentId} {StudentFirstName} {StudentLastName} Major: {StudentMajor}");
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int DepartmentNumberOfStudents { get; set; }

        public Department(string name, string code, int id = 0)
        {
            DepartmentName = name;
            DepartmentCode = code;
            DepartmentId = id;
            DepartmentNumberOfStudents = 0;
        }

        public override string ToString()
        {
            return string.Format($"#{DepartmentId} {DepartmentName} {DepartmentCode} Students: {DepartmentNumberOfStudents}");
        }

    }
}
