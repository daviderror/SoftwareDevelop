using DChalyanApp1.SoftwareDevelop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain
{
    public class Freelancer : Person
    {        public Freelancer(string name,List<TimeRecord> timeRecords) : base(name,timeRecords)
        {
        }    }
}
