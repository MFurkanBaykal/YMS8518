using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RelationShip4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCustomerDemoController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public CustomerCustomerDemoController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var customerDemos = _unitOfWork.CustomerCustomerDemoRepository.GetAll();
            return new JsonResult(customerDemos);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customerDemos = _unitOfWork.CustomerCustomerDemoRepository.GetById(id);
            return new JsonResult(customerDemos);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.CustomerCustomerDemo customerDemo)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Insert(customerDemo);
            _unitOfWork.Complete();
            return new JsonResult(customerDemo);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.CustomerCustomerDemo customerDemo)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Update(customerDemo);
            _unitOfWork.Complete();
            return new JsonResult(customerDemo);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}