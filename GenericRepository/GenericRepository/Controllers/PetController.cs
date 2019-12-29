using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public PetController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _unitOfWork.PetRepository.GetAll();
            return new JsonResult(users);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Pet pet)
        {
            _unitOfWork.PetRepository.Insert(pet);
            _unitOfWork.Complete();
            return new JsonResult(pet);
        }
    }
}