using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeaveManagerModel.Model;

namespace LeaveManagerModel.Controllers
{
    public class LeaveManagerController : Controller
    {
        [HttpGet]
        [Route("api/leavehistory")]
        public List<LeaveManagerClass> Get()
        {
            Console.WriteLine("entered!");
            LeaveManagerDbContext db = new LeaveManagerDbContext();
            List<LeaveManagerClass> leaveHis = db.LeaveManager.ToList();
            return leaveHis;
        }        
    };
}