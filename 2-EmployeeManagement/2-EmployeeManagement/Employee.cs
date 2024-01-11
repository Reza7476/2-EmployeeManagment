namespace _2_EmployeeManagement;


public abstract class Employee
{
    public Employee(string name, int employeeId, int salary)
    {
        Name = name;
        EmployeeId = employeeId;
        Salary = salary;
    }
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public int Salary { get; set; }
    public abstract void PrintDetails();
}


public class RegularEmployee : Employee
{
    public RegularEmployee(string name, int employeeId, int salary) : base(name, employeeId, salary)
    {

    }
    public override void PrintDetails()
    {
        Console.WriteLine($"name: {Name} salary: {Salary}");
    }
}


public class Manager : Employee
{
    public Manager(string name, int employeeId, string department, int salary) : base(name, employeeId, salary)
    {
        Department = department;
    }
    public string Department { get; set; }

    public override void PrintDetails()
    {
        Console.WriteLine($" name: {Name} salary: {Salary} {Department} manager");
    }
}


