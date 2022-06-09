public class Person //class person
{
    public int Person_Id { get; set; }
    public string Person_Name { get; set; }


    public bool InsertIntoPersonTable(Person ps) //Method dùng để insert data person vào table
    {
        return true;
    }
}

public class IReportGeneration //tạo 1 class interface có methods xuất report
{

    public virtual void GenerateReport(Person ps)
    {
        
    }
}

public class CrystalReportGeneraion : IReportGeneration //class có method xuất report qua Crystal Report inherits từ class interface trên
{
    public override void GenerateReport(Person ps)
    {
        
    }
}

public class PDFReportGeneraion : IReportGeneration //class có method xuất report qua file PDF inherits từ class interface trên
{
    public override void GenerateReport(Person ps)
    {
        
    }
}


public abstract class Employee
{
    public virtual string GetProjectDetails(int employeeId) //methos lấy chi tiết thông tin project
    {
        return "Base Project";
    }
    public virtual string GetEmployeeDetails(int employeeId) //methos lấy chi tiết thông tin nhân viên
    {
        return "Base Employee";
    }
}
public interface IEmployee
{
    string GetEmployeeDetails(int employeeId);
}

public interface IProject
{
    string GetProjectDetails(int employeeId);
}
public class CasualEmployee : IEmployee,IProject
{
    public string GetProjectDetails(int employeeId)
    {
        return "Child Project";
    }
    public string GetEmployeeDetails(int employeeId)
    {
        return "Child Employee";
    }
}

public class ContractualEmployee : IProject
{
    public string GetProjectDetails(int employeeId)
    {
        return "Child Project";
    }
    //public string GetEmployeeDetails(int employeeId)
    //{
    //    throw new NotImplementedException();
    //}
}
public interface IAddOperation
{
    bool AddEmployeeDetails();
}
public interface IGetOperation
{
    bool ShowEmployeeDetails(int employeeId);
}
public interface IMessenger
{
    void SendMessage();
}
public class Email : IMessenger
{
    public void SendMessage()
    {
        // methods send thông báo qua email
    }
}

public class SMS : IMessenger
{
    public void SendMessage()
    {
        // methods send thông báo qua SMS
    }
}
public class Notification
{
    private IMessenger _iMessenger;
    public Notification()
    {
        _iMessenger = new Email();
    }
    public void DoNotify()
    {
        _iMessenger.SendMessage();
    }
}
class Program
{
    static void Main(string[] args)
    {
        
    }
}