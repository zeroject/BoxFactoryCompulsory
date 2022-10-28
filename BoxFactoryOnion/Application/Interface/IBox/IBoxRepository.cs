using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IBox
{
    public interface IBoxRepository
    {
        public Box CreateNewBox(Box box);
        public List<Box> GetAllBoxes();
        public Box UpdateBox(Box box);
        public void DeleteBox(Box box);
    }
}
