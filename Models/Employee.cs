using System.Collections.Generic;

namespace LINQ.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public int EmployeeID { get; set; } 

        public int Age { get; set; }    

        public string Department { get; set; }


    }

    public class EmployeeStructure
    {
        public List<Employee> GetEmployeeList()
        {
            List<Employee> returnList = new List<Employee>();

            Employee emp1 = new Employee();

            Employee emp2 = new Employee();

            Employee emp3 = new Employee();

            Employee emp4 = new Employee();

            Employee emp5 = new Employee();

            Employee emp6 = new Employee();

            emp1.Name = "Shubham Jangid";
            emp1.Age = 21;
            emp1.EmployeeID = 1;
            emp1.Department = "Dotnet";

            emp2.Name = "Abhijeet Desai";
            emp2.Age = 21;
            emp2.EmployeeID = 2;
            emp2.Department = "React";

            emp3.Name = "Karan gadekar";
            emp3.Age = 31;
            emp3.EmployeeID = 3;
            emp3.Department = "Python";

            emp4.Name = "Rohan Koli";
            emp4.Age = 24;
            emp4.EmployeeID = 4;
            emp4.Department = "QC";

            emp5.Name = "Prathamesh Chaughule";
            emp5.Age = 24;
            emp5.EmployeeID = 5;
            emp5.Department = "PhP";

            emp6.Name = "Sakshi Patil";
            emp6.Age = 28;
            emp6.EmployeeID = 6;
            emp6.Department = "HR";

            returnList.Add(emp1);
            returnList.Add(emp2);
            returnList.Add(emp3);
            returnList.Add(emp4);
            returnList.Add(emp5);
            returnList.Add(emp6);

            return returnList;


        }
    }
    
}
