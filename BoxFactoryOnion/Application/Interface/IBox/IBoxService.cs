using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IBox
{
    public interface IBoxService
    {
        public Box CreateNewBox(Box box);
        public List<Box> GetAllBoxes();
    }
}
