using BaseballMVC.Models;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Metadata.Ecma335;

namespace BaseballMVC
{
    public class RequestRepository : IRequestRepository
    {
		Request[] requests = new Request[]
			{
				new Request {requestID = 1, employeeID = 1, numOfTickets = 2, dateRequested = "2022-04-01T12:00:00Z", gameDate = "2022-04-15T19:10:00Z", entryTime = "2022-04-15T18:30:00Z", isApproved = "yes"},
				new Request {requestID = 2, employeeID = 1, numOfTickets = 2, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-20T20:05:00Z", entryTime = "2022-04-20T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 3, employeeID = 2, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-22T20:05:00Z", entryTime = "2022-04-22T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 4, employeeID = 2, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-24T20:05:00Z", entryTime = "2022-04-24T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 5, employeeID = 3, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-28T20:05:00Z", entryTime = "2022-04-28T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 6, employeeID = 4, numOfTickets = 6, dateRequested = "2022-05-01T12:00:00Z", gameDate = "2022-06-15T19:10:00Z", entryTime = "", isApproved = "yes"},
				new Request {requestID = 7, employeeID = 4, numOfTickets = 6, dateRequested = "2022-05-01T10:00:00Z", gameDate = "2022-07-20T20:05:00Z", entryTime = "2022-07-20T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 8, employeeID = 4, numOfTickets = 4, dateRequested = "2022-05-04T10:00:00Z", gameDate = "2022-08-22T20:05:00Z", entryTime = "2022-08-22T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 9, employeeID = 5, numOfTickets = 4, dateRequested = "2022-07-10T10:00:00Z", gameDate = "2022-07-24T20:05:00Z", entryTime = "2022-07-24T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 10, employeeID = 6, numOfTickets = 2, dateRequested = "2022-08-11T10:00:00Z", gameDate = "2022-08-28T20:05:00Z", entryTime = "2022-08-28T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 11, employeeID = 7, numOfTickets = 5, dateRequested = "2022-04-22T12:00:00Z", gameDate = "2022-07-04T19:10:00Z", entryTime = "2022-07-04T18:30:00Z", isApproved = "yes"},
				new Request {requestID = 12, employeeID = 7, numOfTickets = 5, dateRequested = "2022-04-22T10:00:00Z", gameDate = "2022-09-05T20:05:00Z", entryTime = "2022-09-05T19:55:00Z", isApproved = "yes"},
				new Request {requestID = 13, employeeID = 8, numOfTickets = 4, dateRequested = "2022-05-18T10:00:00Z", gameDate = "2022-05-30T20:05:00Z", entryTime = "2022-05-30T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 14, employeeID = 9, numOfTickets = 4, dateRequested = "2022-06-06T10:00:00Z", gameDate = "2022-07-04T20:05:00Z", entryTime = "2022-07-04T19:35:00Z", isApproved = "yes"},
				new Request {requestID = 15, employeeID = 10, numOfTickets = 2, dateRequested = "2022-08-18T10:00:00Z", gameDate = "2022-09-11T20:05:00Z", entryTime = "2022-09-11T19:45:00Z", isApproved = "yes"},
				new Request {requestID = 16, employeeID = 11, numOfTickets = 7, dateRequested = "2022-03-31T12:00:00Z", gameDate = "2022-04-15T19:10:00Z", entryTime = "2022-04-15T18:36:00Z", isApproved = "yes"},
				new Request {requestID = 17, employeeID = 11, numOfTickets = 2, dateRequested = "2022-03-31T10:00:00Z", gameDate = "2022-04-07T20:05:00Z", entryTime = "", isApproved = "yes"},
				new Request {requestID = 18, employeeID = 12, numOfTickets = 5, dateRequested = "2022-03-15T10:00:00Z", gameDate = "2022-04-22T20:05:00Z", entryTime = "2022-04-22T19:49:00Z", isApproved = "yes"},
				new Request {requestID = 19, employeeID = 13, numOfTickets = 4, dateRequested = "2022-06-11T10:00:00Z", gameDate = "2022-06-24T20:05:00Z", entryTime = "2022-06-24T19:25:00Z", isApproved = "yes"},
				new Request {requestID = 20, employeeID = 14, numOfTickets = 3, dateRequested = "2022-06-18T10:00:00Z", gameDate = "2022-06-18T20:05:00Z", entryTime = "2022-06-18T19:42:00Z", isApproved = "yes"},
				new Request {requestID = 21, employeeID = 15, numOfTickets = 4, dateRequested = "2022-05-31T12:00:00Z", gameDate = "2022-05-31.0T19:10:00Z", entryTime = "2022-05-31T18:46:00Z", isApproved = "yes"},
				new Request {requestID = 22, employeeID = 15, numOfTickets = 2, dateRequested = "2022-05-31T10:00:00Z", gameDate = "2022-06-07T20:05:00Z", entryTime = "2022-06-07T19:15:00Z", isApproved = "yes"},
				new Request {requestID = 23, employeeID = 15, numOfTickets = 5, dateRequested = "2022-05-31T10:00:00Z", gameDate = "2022-07-22T20:05:00Z", entryTime = "2022-07-22T19:49:00Z", isApproved = "yes"},
				new Request {requestID = 24, employeeID = 16, numOfTickets = 3, dateRequested = "2022-06-21T10:00:00Z", gameDate = "2022-06-24T20:05:00Z", entryTime = "2022-06-24T19:35:00Z", isApproved = "yes"},
				new Request {requestID = 25, employeeID = 16, numOfTickets = 6, dateRequested = "2022-06-21T10:00:00Z", gameDate = "2022-07-18T20:05:00Z", entryTime = "2022-07-18T19:42:00Z", isApproved = "yes"},
				new Request {requestID = 26, employeeID = 17, numOfTickets = 4, dateRequested = "2022-07-31T10:00:00Z", gameDate = "2022-07-07T20:05:00Z", entryTime = "2022-07-07T19:15:00Z", isApproved = "yes"},
				new Request {requestID = 27, employeeID = 18, numOfTickets = 5, dateRequested = "2022-09-01T10:00:00Z", gameDate = "2022-09-22T20:05:00Z", entryTime = "2022-09-22T19:49:00Z", isApproved = "yes"},
				new Request {requestID = 28, employeeID = 19, numOfTickets = 6, dateRequested = "2022-09-21T10:00:00Z", gameDate = "2022-09-24T20:05:00Z", entryTime = "2022-09-24T19:35:00Z", isApproved = "yes"},
				new Request {requestID = 29, employeeID = 20, numOfTickets = 3, dateRequested = "2022-08-18T19:00:00Z", gameDate = "2022-08-18T20:05:00Z", entryTime = "2022-08-18T19:42:00Z", isApproved = "yes"},

			};
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
		public Request[] RequestTickets()
        {
            Request[] request = new Request[]
            {
                new Request {requestID = 1, employeeID = 1, numOfTickets = 2, dateRequested = "2022-04-01T12:00:00Z", gameDate = "2022-04-15T19:10:00Z", entryTime = "2022-04-15T18:30:00Z", isApproved = "yes"},
                new Request {requestID = 2, employeeID = 1, numOfTickets = 2, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-20T20:05:00Z", entryTime = "2022-04-20T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 3, employeeID = 2, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-22T20:05:00Z", entryTime = "2022-04-22T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 4, employeeID = 2, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-24T20:05:00Z", entryTime = "2022-04-24T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 5, employeeID = 3, numOfTickets = 4, dateRequested = "2022-04-01T10:00:00Z", gameDate = "2022-04-28T20:05:00Z", entryTime = "2022-04-28T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 6, employeeID = 4, numOfTickets = 6, dateRequested = "2022-05-01T12:00:00Z", gameDate = "2022-06-15T19:10:00Z", entryTime = "", isApproved = "yes"},
                new Request {requestID = 7, employeeID = 4, numOfTickets = 6, dateRequested = "2022-05-01T10:00:00Z", gameDate = "2022-07-20T20:05:00Z", entryTime = "2022-07-20T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 8, employeeID = 4, numOfTickets = 4, dateRequested = "2022-05-04T10:00:00Z", gameDate = "2022-08-22T20:05:00Z", entryTime = "2022-08-22T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 9, employeeID = 5, numOfTickets = 4, dateRequested = "2022-07-10T10:00:00Z", gameDate = "2022-07-24T20:05:00Z", entryTime = "2022-07-24T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 10, employeeID = 6, numOfTickets = 2, dateRequested = "2022-08-11T10:00:00Z", gameDate = "2022-08-28T20:05:00Z", entryTime = "2022-08-28T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 11, employeeID = 7, numOfTickets = 5, dateRequested = "2022-04-22T12:00:00Z", gameDate = "2022-07-04T19:10:00Z", entryTime = "2022-07-04T18:30:00Z", isApproved = "yes"},
                new Request {requestID = 12, employeeID = 7, numOfTickets = 5, dateRequested = "2022-04-22T10:00:00Z", gameDate = "2022-09-05T20:05:00Z", entryTime = "2022-09-05T19:55:00Z", isApproved = "yes"},
                new Request {requestID = 13, employeeID = 8, numOfTickets = 4, dateRequested = "2022-05-18T10:00:00Z", gameDate = "2022-05-30T20:05:00Z", entryTime = "2022-05-30T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 14, employeeID = 9, numOfTickets = 4, dateRequested = "2022-06-06T10:00:00Z", gameDate = "2022-07-04T20:05:00Z", entryTime = "2022-07-04T19:35:00Z", isApproved = "yes"},
                new Request {requestID = 15, employeeID = 10, numOfTickets = 2, dateRequested = "2022-08-18T10:00:00Z", gameDate = "2022-09-11T20:05:00Z", entryTime = "2022-09-11T19:45:00Z", isApproved = "yes"},
                new Request {requestID = 16, employeeID = 11, numOfTickets = 7, dateRequested = "2022-03-31T12:00:00Z", gameDate = "2022-04-15T19:10:00Z", entryTime = "2022-04-15T18:36:00Z", isApproved = "yes"},
                new Request {requestID = 17, employeeID = 11, numOfTickets = 2, dateRequested = "2022-03-31T10:00:00Z", gameDate = "2022-04-07T20:05:00Z", entryTime = "", isApproved = "yes"},
                new Request {requestID = 18, employeeID = 12, numOfTickets = 5, dateRequested = "2022-03-15T10:00:00Z", gameDate = "2022-04-22T20:05:00Z", entryTime = "2022-04-22T19:49:00Z", isApproved = "yes"},
                new Request {requestID = 19, employeeID = 13, numOfTickets = 4, dateRequested = "2022-06-11T10:00:00Z", gameDate = "2022-06-24T20:05:00Z", entryTime = "2022-06-24T19:25:00Z", isApproved = "yes"},
                new Request {requestID = 20, employeeID = 14, numOfTickets = 3, dateRequested = "2022-06-18T10:00:00Z", gameDate = "2022-06-18T20:05:00Z", entryTime = "2022-06-18T19:42:00Z", isApproved = "yes"},
                new Request {requestID = 21, employeeID = 15, numOfTickets = 4, dateRequested = "2022-05-31T12:00:00Z", gameDate = "2022-05-31.0T19:10:00Z", entryTime = "2022-05-31T18:46:00Z", isApproved = "yes"},
                new Request {requestID = 22, employeeID = 15, numOfTickets = 2, dateRequested = "2022-05-31T10:00:00Z", gameDate = "2022-06-07T20:05:00Z", entryTime = "2022-06-07T19:15:00Z", isApproved = "yes"},
                new Request {requestID = 23, employeeID = 15, numOfTickets = 5, dateRequested = "2022-05-31T10:00:00Z", gameDate = "2022-07-22T20:05:00Z", entryTime = "2022-07-22T19:49:00Z", isApproved = "yes"},
                new Request {requestID = 24, employeeID = 16, numOfTickets = 3, dateRequested = "2022-06-21T10:00:00Z", gameDate = "2022-06-24T20:05:00Z", entryTime = "2022-06-24T19:35:00Z", isApproved = "yes"},
                new Request {requestID = 25, employeeID = 16, numOfTickets = 6, dateRequested = "2022-06-21T10:00:00Z", gameDate = "2022-07-18T20:05:00Z", entryTime = "2022-07-18T19:42:00Z", isApproved = "yes"},
                new Request {requestID = 26, employeeID = 17, numOfTickets = 4, dateRequested = "2022-07-31T10:00:00Z", gameDate = "2022-07-07T20:05:00Z", entryTime = "2022-07-07T19:15:00Z", isApproved = "yes"},
                new Request {requestID = 27, employeeID = 18, numOfTickets = 5, dateRequested = "2022-09-01T10:00:00Z", gameDate = "2022-09-22T20:05:00Z", entryTime = "2022-09-22T19:49:00Z", isApproved = "yes"},
                new Request {requestID = 28, employeeID = 19, numOfTickets = 6, dateRequested = "2022-09-21T10:00:00Z", gameDate = "2022-09-24T20:05:00Z", entryTime = "2022-09-24T19:35:00Z", isApproved = "yes"},
                new Request {requestID = 29, employeeID = 20, numOfTickets = 3, dateRequested = "2022-08-18T19:00:00Z", gameDate = "2022-08-18T20:05:00Z", entryTime = "2022-08-18T19:42:00Z", isApproved = "yes"},

            };
            return request;

        }
        public Request[] GetRequestByEmployeeId(int id)
        {
            var filtered = requests.Where(x => x.employeeID == id);

            return filtered.ToArray();

        }

    }

    
}
