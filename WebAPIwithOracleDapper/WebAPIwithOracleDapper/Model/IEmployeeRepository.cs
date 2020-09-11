namespace WebAPIwithOracleDapper.Model
{
    public interface IEmployeeRepository
    {
        object GetEmployeeList();

        object GetEmployeeDetails(int empId);

    }
}
