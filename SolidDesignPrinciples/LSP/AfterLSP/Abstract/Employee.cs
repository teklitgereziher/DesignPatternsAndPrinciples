using SolidDesignPrinciples.LSP.AfterLSP;

namespace SolidPrinciples.LSP.Abstract.AfterLSP
{
    /// <summary>
    /// Make this class closed for modification and open for extension by making it an abstaract class.
    /// New features will extend this class and add their own new features
    /// </summary>
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }     

        public Employee() { }
        public Employee(int id, string name)
        {
            Id = id; 
            Name = name;
        }
        public abstract decimal GetMinimumSalary();
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", Id, Name);
        }
    }
}
