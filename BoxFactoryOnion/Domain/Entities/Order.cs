using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int CustomerID { get; set; }
        public double? TotalPrice { get; set; }
        public bool isDone { get; set; }
        public string? StatusCode { get; set; }
    }
}
