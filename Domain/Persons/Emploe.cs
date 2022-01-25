using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persons
{
    class Emploe:Staff
    {
        public Emploe(string name,List<TimeRecord>timeRecords) : base(name, 120000,timeRecords)
        {

        }
    }
}