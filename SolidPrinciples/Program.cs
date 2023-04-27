using EmployeeAfterOCP = SolidPrinciples.OCP.AfterOCP;
using EmployeeBeforeOCP = SolidPrinciples.OCP.BeforeOCP;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Before Applying OCP
            EmployeeBeforeOCP.Employee empJohn = new EmployeeBeforeOCP.Employee(1, "John", "Permanent");
            EmployeeBeforeOCP.Employee empJason = new EmployeeBeforeOCP.Employee(2, "Jason", "Temp");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJason.ToString(),
                empJason.CalculateBonus(150000).ToString()));

            Console.ReadLine();
            //--------------------------------------------------------------

            // After Appllying OCP
            EmployeeAfterOCP.Employee john = new EmployeeAfterOCP.PermanentEmployee(1, "John");
            EmployeeAfterOCP.Employee jason = new EmployeeAfterOCP.TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                john.ToString(),
                john.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              jason.ToString(),
              jason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
            //--------------------------------------------------------------
        }
    }
}