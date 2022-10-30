using Application.DTOs;
using Application.Interface.IDatabase;
using Application.Interface.IOrder;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class DataBaseService : IDataBaseService
    {
        private IDataBaseRepository _dataBaseRepository;  

        public DataBaseService(IDataBaseRepository dataBaseRepository)
        {
            _dataBaseRepository = dataBaseRepository;
        }

        public void RecreateDB()
        {
            _dataBaseRepository.RecreateDB();
        }
    }
}
