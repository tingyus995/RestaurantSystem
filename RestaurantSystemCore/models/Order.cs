using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystemCore.models
{
    
    
    public class Order
    {
        public enum OrderStatus
        {
            Queuing,
            Making,
            Ready,
            Finished,
            Cancelled
        }
        public int Id { get; set; }
        public Food[] Foods { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public OrderStatus Status { get; set; }
    }
}
