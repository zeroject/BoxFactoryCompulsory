using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string CompanyName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
