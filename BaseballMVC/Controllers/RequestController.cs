using BaseballMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaseballMVC.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestRepository repo;

        public RequestController(IRequestRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult ViewRequest(int id)
        {
            var requests = repo.GetRequestByEmployeeId(id);
            return View(requests);
        }
    }
}
