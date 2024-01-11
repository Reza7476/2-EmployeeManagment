namespace _2_EmployeeManagement;
public abstract class Secretariat
{
    static List<Employee> _employees = new();
    public static void RegisterEmployee(string name, int employeeId, int salary)
    {
        RegularEmployee employee = new RegularEmployee(name, employeeId, salary);
        _employees.Add(employee);
        Success();
    }
    public static void RegisterEmployee(string name, int employeeId, int salary, string department)
    {
        Manager manager = new(name, employeeId, department, salary);
        _employees.Add(manager);
        Success();
    }
    public static void GetEmployess(string name)
    {
        var employee = _employees.Find(_ => _.Name == name);
        if (employee == null)
        {
            throw new Exception("employee not fount");

        }
        employee.PrintDetails();


    }

    public static bool IsEmployeeExist(string name)
    {
        bool result = false;
        var employeeName = _employees.Find(_ => _.Name == name);
        if (employeeName != null)
        {
            result = true;
        }
        return result;
    }






    public static int Run()
    {
        int run;
        Console.WriteLine($"\n 1: Add new employee" +
            $"\n 2: Display details" +
            $"\n 0: Exite");
        run = int.Parse(Console.ReadLine()!);
        return run;
    }

    public static string GetString(string message)
    {

        string value;
        Console.WriteLine(message);
        value = Console.ReadLine()!;
        return value;
    }

    public static int GetIntiger(string message)
    {
        int value;
        Console.WriteLine(message);
        value = int.Parse(Console.ReadLine()!);
        return value;
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"------------\n{message}\n-----------");
        Console.ResetColor();
    }

    public static void Success()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"-------------\nSuccess full\n-------------");
        Console.ResetColor();

    }


}
