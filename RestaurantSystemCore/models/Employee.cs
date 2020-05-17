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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public bool LateCheck { get; set; }
        public string LateCheckReason { get; set; }
    }
}