using EmployeeAfterOCP = SolidPrinciples.OCP.AfterOCP;
using EmployeeBeforeOCP = SolidPrinciples.OCP.BeforeOCP;
using EmployeeBeforeLSP = SolidPrinciples.LSP.BeforeLSP;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Begin --------------------- Open-Closed Principle --------------------- 
            // Before Applying OCP
            EmployeeBeforeOCP.Employee empJohn = new EmployeeBeforeOCP.Employee(1, "John", "Permanent");
            EmployeeBeforeOCP.Employee empJason = new EmployeeBeforeOCP.Employee(2, "Jason", "Temp");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJason.ToString(),
                empJason.CalculateBonus(150000).ToString()));

            //Console.ReadLine();

            // After Appllying OCP
            EmployeeAfterOCP.Employee john = new EmployeeAfterOCP.PermanentEmployee(1, "John");
            EmployeeAfterOCP.Employee jason = new EmployeeAfterOCP.TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                john.ToString(),
                john.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              jason.ToString(),
              jason.CalculateBonus(150000).ToString()));
            //Console.ReadLine();
            // End --------------------- Open-Closed Principle ---------------------

            // Begin --------------------- Liskov Substitution Principle ---------------------
            // Before LSP
            EmployeeBeforeLSP.Employee jo = new EmployeeBeforeLSP.PermanentEmployee(1, "John");
            EmployeeBeforeLSP.Employee ja = new EmployeeBeforeLSP.TemporaryEmployee(2, "Jason");
            EmployeeBeforeLSP.Employee mik = new EmployeeBeforeLSP.ContractEmployee(3, "Mike");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                jo.ToString(),
                jo.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              ja.ToString(),
              ja.CalculateBonus(150000).ToString()));
            // this method call will throw an exception.
            // Hence the ContractEmployee voilates the LSP 
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              mik.ToString(),
              mik.CalculateBonus(150000).ToString()));
            Console.ReadLine();

            // After LSP

            // End --------------------- Liskov Substitution Principle ---------------------
        }
    }
}