using SolidPrinciples.OCP.AfterOCP;
using SolidPrinciples.OCP.BeforeOCP;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Before Applying OCP
            //OCP.BeforeOCP.Employee empJohn = new OCP.BeforeOCP.Employee(1, "John", "Permanent");
            //OCP.BeforeOCP.Employee empJason = new OCP.BeforeOCP.Employee(2, "Jason", "Temp");

            //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            //    empJohn.ToString(),
            //    empJohn.CalculateBonus(100000).ToString()));

            //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            //    empJason.ToString(),
            //    empJason.CalculateBonus(150000).ToString()));

            //Console.ReadLine();
            //--------------------------------------------------------------

            // After Appllying OCP
            OCP.AfterOCP.Employee john = new PermanentEmployee(1, "John");
            OCP.AfterOCP.Employee jason = new TemporaryEmployee(2, "Jason");

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