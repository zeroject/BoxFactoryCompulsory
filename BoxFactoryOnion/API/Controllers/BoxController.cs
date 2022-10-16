using Application.DTOs;
using Application.Interface;
using Application.Interface.IBox;
using Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoxController : ControllerBase
    {
        private IBoxService _boxService;
        public BoxController(IBoxService boxService)
        {
            _boxService = boxService;
        }

        [HttpGet]
        public List<Box> GetAllBoxes()
        {
            return _boxService.GetAllBoxes();
        }

        [HttpPost]
        public ActionResult<Box> CreateNewBox(Box box)
        {
            try
            {
                var result = _boxService.CreateNewBox(box);
                return Created("box/" + result.Id, result);
            } 
            catch(ValidationException e)
            {
                return BadRequest(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
