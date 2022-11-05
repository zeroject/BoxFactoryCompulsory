using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetBoxDTO
    {
        public string BoxName { get; set; }
        public double Price { get; set; }
        public int boxOrderNum { get; set; }
    }
}
