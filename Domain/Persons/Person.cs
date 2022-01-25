using Domain;
using System;
using System.Collections.Generic;

namespace DChalyanApp1.SoftwareDevelop.Domain
{
    public class Person
    {
        public string Name { get; }
        public List<TimeRecord> TimeRecords { get; set; }
        public Person(string name, List<TimeRecord> timeRecords)
        {
            Name = name;
            TimeRecords = timeRecords;
        }
    }
}
