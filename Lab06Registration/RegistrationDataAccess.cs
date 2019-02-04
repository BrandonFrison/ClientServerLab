using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lab06Registration
{
    public class RegistrationDataAccess
    {
        // This member will be used by all methods.
        private SqlConnection registrationDBConnection = null;
        public void OpenConnection()
        {
            registrationDBConnection = new SqlConnection();
            registrationDBConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=SSPI;" +
                "Initial Catalog=StudentRegistration";
            registrationDBConnection.Open();
        }

        public void CloseConnection()
        {
            registrationDBConnection.Close();
        }

        // Given a Student object, insert it into the database using SQL command

        public void InsertStudent(Student s)
        {

        }

        // Using SQL Select, return a List of all students in the database

        public List<Student> GetStudents()
        {
            //List<Student> allStudentsList = (from s in )

           // return allStudentsList;
        }

        // Given a Department object, insert it into the database using SQL command

        public void InsertDepartment(Department d)
        {
        }

        // Using SQL Select, return a List of all students in the database

        public List<Department> GetDepartments()
        {
            return null; // CHANGE THIS!!
        }

        // SQL command: TRUNCATE TABLE <tablename>

        public void TruncateData(string table)
        {
        }

        // query the Departments table where d.DepartmentId = DepartmentId
        // Get the count of students, and update the Department object

        public void GetNumberOfStudentsInMajor(Department d)
        {

        }

        // extra credit: no need to use GetDepartments() to generate a List
        // Use SQL to get all departments AND the number of students in each department (major)
        // Hint: use a join and group by

        public List<Department> GetNumberOfStudentsInMajor()
        {
            return null; // CHANGE THIS!!
        }
    }
}