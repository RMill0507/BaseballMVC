using BaseballMVC.Models;

namespace BaseballMVC
{
    public interface IRequestRepository
    {
        public Request[] RequestTickets();


        public Request[] GetRequestByEmployeeId(int id);
        
    }
}
