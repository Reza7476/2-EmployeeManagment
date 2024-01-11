

using _2_EmployeeManagement;
using System.Transactions;

while (true)
{


    try
    {
        int excute = Secretariat.Run();
        switch (excute)
        {
            case 0:
                {

                    Environment.Exit(0);
                    break;
                }
            case 1:
                {
                    var name = Secretariat.GetString("enter name");
                    var checkName = Secretariat.IsEmployeeExist(name);
                    if (checkName == true)
                    {
                        throw new Exception("this employee already  has been registred");
                    }
                    var employeeId = Secretariat.GetIntiger("enter Employee Identity");
                    var salary = Secretariat.GetIntiger("enter salary");
                    var mentionManager = Secretariat.GetIntiger($"\tWhats {name}'s position\n" +
                        $"\t\t1:  manager\n" +
                        $"\t\t2:  regular employee");
                    if (mentionManager == 1)
                    {
                        var department = Secretariat.GetString("enter department");
                        Secretariat.RegisterEmployee(name, employeeId, salary, department);
                    }
                    else if (mentionManager == 2)
                    {
                        Secretariat.RegisterEmployee(name, employeeId, salary);
                    }
                    break;
                }
            case 2:
                {
                    var name = Secretariat.GetString("enter name");
                    Secretariat.GetEmployess(name);
                    break;
                }
            default:
                {
                    Secretariat.Run();
                    break;
                }
        }

    }
    catch (Exception ex)
    {

        Secretariat.Error(ex.Message);
    }
}
