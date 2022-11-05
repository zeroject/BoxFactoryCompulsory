using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetOrderDTO
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double? TotalPrice { get; set; }
        public string StatusCode { get; set; }
    }
}
