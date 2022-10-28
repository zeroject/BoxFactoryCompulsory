using Application.DTOs;
using Application.Interface;
using Application.Interface.IBox;
using Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        public List<GetBoxDTO> GetAllBoxes()
        {
            return _boxService.GetAllBoxes();
        }

        [HttpDelete]
        public ActionResult<Box> DeleteBox(Box box)
        {
            try
            {
                _boxService.DeleteBox(box);
                return Ok();
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Box> UpdateBox(Box box)
        {
            try
            {
                var boxDTO = _boxService.UpdateBox(box);
                return UpdateBox(boxDTO);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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
