using BaseballMVC.Models;

namespace BaseballMVC
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee[] GetEmployees()
        {
            Employee[] employees = new Employee[]
            {
                new Employee { employeeID = 1, name = "Felix Merriweather", email = "johndoe@example.com", department = "Baseball Operations", isAdmin = "no" },
                new Employee { employeeID = 2, name = "Clara Garcia", email = "claragarcia@example.com", department = "Communications", isAdmin = "no" },
                new Employee { employeeID = 3, name = "Samuel Taylor", email = "samueltaylor@example.com", department = "Service Excellence", isAdmin = "no" },
                new Employee { employeeID = 4, name = "David Clark", email = "davidclark@example.com", department = "Finance", isAdmin = "no" },
                new Employee { employeeID = 5, name = "Henry Johnson", email = "henryjohnson@example.com", department = "Finance", isAdmin = "no" },
                new Employee { employeeID = 6, name = "Thomas Wilson", email = "thomaswilson@example.com", department = "Baseball Operations", isAdmin = "no" },
                new Employee { employeeID = 7, name = "Sarah Davis", email = "saradavis@example.com", department = "Human Resources", isAdmin = "yes" },
                new Employee { employeeID = 8, name = "Eliza Jones", email = "elizajones@example.com", department = "Service Excellence", isAdmin = "no" },
                new Employee { employeeID = 9, name = "Elizabeth Clark", email = "elizabethclark@example.com", department = "Finance", isAdmin = "no" },
                new Employee { employeeID = 10, name = "Joseph Martin", email = "jmartin@example.com", department = "Communications", isAdmin = "no" },
                new Employee { employeeID = 11, name = "Charles Johnson", email = "cjohnson@example.com", department = "Human Resources", isAdmin = "yes" },
                new Employee { employeeID = 12, name = "Edward Davis", email = "edavis@example.com", department = "Information Systems", isAdmin = "no" },
                new Employee { employeeID = 13, name = "George Brown", email = "gbrown@example.com", department = "Information Systems", isAdmin = "no" },
                new Employee { employeeID = 14, name = "Alice Smith", email = "alicesmith@example.com", department = "Information Systems", isAdmin = "yes" },
                new Employee { employeeID = 15, name = "John Miller", email = "johnmiller@example.com", department = "Baseball Operations", isAdmin = "no" },
                new Employee { employeeID = 16, name = "Amanda Brown", email = "amandabrown@example.com", department = "Communications", isAdmin = "no" },
                new Employee { employeeID = 17, name = "Henry Goodman", email = "henrygoodman@example.com", department = "Live Experience", isAdmin = "no" },
                new Employee { employeeID = 18, name = "Michael Smith", email = "michaelsmith@example.com", department = "Live Experience", isAdmin = "no" },
                new Employee { employeeID = 19, name = "James Wilson", email = "jameswilson@example.com", department = "Executive", isAdmin = "no" },
                new Employee { employeeID = 20, name = "Bella Stevenson", email = "bstevenson@example.com", department = "Executive", isAdmin = "no"}
            };
            return employees;
        }

    }
}
