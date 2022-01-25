using DChalyanApp1.SoftwareDevelop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Staff : Person
    {
        public decimal MonthSalary { get; set; }
        public Staff(string name,decimal monthSalary,List<TimeRecord>timeRecords) : base(name,timeRecords)
        {
            MonthSalary = monthSalary;
        }
    }
}
