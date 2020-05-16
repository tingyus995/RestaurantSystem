using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore.models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime Birthday { get; set; }
        public string ContactNumber { get; set; }
        public byte[] Image { get; set; }
        public string[] Categories { get; set; }
        public WorkTime[] workTime { get; set; }
    }


    public class WorkTime
    {
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
    }
}