using Application.DTOs;
using Application.Interface.IBox;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class BoxService : IBoxService
    {
        private IBoxRepository _boxRepository;
        private IMapper _mapper;
        private IValidator<GetBoxDTO> _getValidator;
        public BoxService(IBoxRepository boxRepository, IMapper mapper, IValidator<GetBoxDTO> getValidator)
        {
            _boxRepository = boxRepository;
            _mapper = mapper;
            _getValidator = getValidator;
        }

        public Box CreateNewBox(Box box)
        {
            return _boxRepository.CreateNewBox(box);
        }

        public List<Box> GetAllBoxes()
        {
            return _boxRepository.GetAllBoxes();
        }
    }
}
