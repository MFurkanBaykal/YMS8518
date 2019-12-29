using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public StudentController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _unitOfWork.StudentRepository.GetAll();
            return new JsonResult(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _unitOfWork.StudentRepository.GetById(id);
            return new JsonResult(user);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Models.Student student)
        {
            _unitOfWork.StudentRepository.Insert(student);
            _unitOfWork.Complete();
            return new JsonResult(student);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Student student)
        {
            _unitOfWork.StudentRepository.Update(student);
            _unitOfWork.Complete();
            return new JsonResult(student);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _unitOfWork.StudentRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult(id);
        }

    }
}