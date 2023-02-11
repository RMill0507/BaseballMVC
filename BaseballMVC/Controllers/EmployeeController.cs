using Microsoft.AspNetCore.Mvc;

namespace BaseballMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var employees = repo.GetEmployees();
            return View(employees);
        }
        
    }
}
