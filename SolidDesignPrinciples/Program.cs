using EmployeeAfterLSP = SolidPrinciples.LSP.Abstract.AfterLSP;
using EmployeeAfterOCP = SolidPrinciples.OCP.AfterOCP;
using EmployeeBeforeLSP = SolidPrinciples.LSP.BeforeLSP;
using EmployeeBeforeOCP = SolidPrinciples.OCP.BeforeOCP;
using EmployeeImplementationsAfterLSP = SolidPrinciples.LSP.Implementations.AfterLSP;
using IEmployeeAfterLSP = SolidDesignPrinciples.LSP.AfterLSP;

namespace SolidPrinciples
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("SOLID and Design principles!");

      // Begin --------------------- Open-Closed Principle
      DemoOpenClosedPrinciple();
      // End --------------------- Open-Closed Principle

      // Begin --------------------- Liskov Substitution Principle
      DemoLiskovSubstitutionPrinciple();
      // End --------------------- Liskov Substitution Principle

      Console.ReadLine();
    }

    private static void DemoLiskovSubstitutionPrinciple()
    {
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
      //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
      //  mik.ToString(),
      //  mik.CalculateBonus(150000).ToString()));


      // After LSP
      List<EmployeeAfterLSP.Employee> employees =
            [
                new EmployeeImplementationsAfterLSP.PermanentEmployee(1, "John"),
                new EmployeeImplementationsAfterLSP.TemporaryEmployee(2, "Jason"),
                // This gives a compile time error, which would have thrown a run-time error if LSP have not been applied.
                //new EmployeeImplementationsAfterLSP.ContractEmployee(2, "Jason")
            ];
      foreach (var employee in employees)
      {
        Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            employee.ToString(),
            employee.CalculateBonus(150000).ToString(),
            employee.GetMinimumSalary().ToString()));
      }
      Console.WriteLine();
      List<IEmployeeAfterLSP.IEmployee> employeeList =
            [
                new EmployeeImplementationsAfterLSP.PermanentEmployee(1, "John"),
                new EmployeeImplementationsAfterLSP.TemporaryEmployee(2, "Jason"),
                new EmployeeImplementationsAfterLSP.ContractEmployee(3, "Mike")
            ];
      foreach (var employee in employeeList)
      {
        Console.WriteLine(string.Format("Employee {0} MinSalary: {1}",
            employee.ToString(),
            employee.GetMinimumSalary().ToString()));
      }
      Console.WriteLine();
    }

    private static void DemoOpenClosedPrinciple()
    {
      // Before Applying OCP
      EmployeeBeforeOCP.Employee empJohn = new(1, "John", "Permanent");
      EmployeeBeforeOCP.Employee empJason = new(2, "Jason", "Temp");

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
    }
  }
}
