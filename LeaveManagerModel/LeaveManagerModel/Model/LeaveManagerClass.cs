using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagerModel.Model
{
    public class LeavHistoryList
    {
        public List<LeaveManagerClass> LeaveHistory { get; set; }
    }

    public class LeaveManagerClass
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeNane { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public int LeaveBalance { get; set; }
        public string LeaveStatus { get; set; }
    }

    public class LeaveManagerDbContext : DbContext
    {
        public DbSet<LeaveManagerClass> LeaveManager { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("data source=locahost; integrity security=yes; intial catalog=LeaveManager");
        }
    }
}