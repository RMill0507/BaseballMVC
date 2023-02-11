using System.ComponentModel.DataAnnotations;

namespace BaseballMVC.Models
{
    public class Employee
    {

        public int employeeID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string isAdmin { get; set; }
    }
  

}
