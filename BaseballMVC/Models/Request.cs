namespace BaseballMVC.Models
{
    public class Request
    {
        public int requestID { get; set; }  
        public int employeeID { get; set; }
        public int numOfTickets { get; set; }
        public string dateRequested { get; set; }
        public string gameDate { get; set; }
        public string entryTime { get; set; }
        public string isApproved { get; set; }  
    }
}
