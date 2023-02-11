using BaseballMVC.Models;

namespace BaseballMVC
{
    public interface IEmployeeRepository
    {
        public Employee[] GetEmployees();
    }
}
