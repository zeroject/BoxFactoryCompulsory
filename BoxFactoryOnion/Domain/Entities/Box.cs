using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Box
    {
        public int Id { get; set; }
        public string BoxName { get; set; }
        public string BoxDescription { get; set; }
        public double BoxWidth { get; set; }
        public double BoxHieght { get; set; }
        public double BoxDepth { get; set; }
        public double Price { get; set; }
        public bool isFolded { get; set; }
    }
}
