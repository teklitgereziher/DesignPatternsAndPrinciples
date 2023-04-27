namespace SolidPrinciples.OCP.AfterOCP
{
    /// <summary>
    /// Make this class closed for modification and open for extension by making it an abstaract class.
    /// New features will extend this class and add their own new features
    /// </summary>
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee() { }
        public Employee(int id, string name)
        {
            ID = id; 
            Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
