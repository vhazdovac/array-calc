using System;
using ArrayCalcAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArrayCalcAPI.Controllers
{
    [Route("api/[controller]")]
    public class ArrayCalcController : Controller
    {
        private readonly IArrayManipulationService _arrayManipulationService;

        public ArrayCalcController(IArrayManipulationService arrayManipulationService)
        {
            _arrayManipulationService = arrayManipulationService;
        }

        // GET api/arraycalc
        [HttpGet]
        public IActionResult GetHome()
        {
            return Ok("Array Calc API");
        }

        // GET api/arraycalc/reverse
        [HttpGet("reverse")]
        public IActionResult GetReversed([FromQuery]string [] productIds)
        {
            try
            {
                var result = _arrayManipulationService.ReverseArray(productIds);
                return Ok(result);
            } 
            catch (Exception e)
            {
                return BadRequest("Error while reversing array: " + e.Message);
            }
        }

        // GET api/arraycalc/deletepart
        [HttpGet("deletepart")]
        public IActionResult GetDeleted([FromQuery]string position, [FromQuery]string[] productIds)
        {
            try
            {
                var result = _arrayManipulationService.DeleteArrayElement(productIds, position);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest("Error while deleteng element: " + e.Message);
            }
        }
    }
}
