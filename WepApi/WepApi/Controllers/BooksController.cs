using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly Interfaces.IBookRepository _bookRepository;
        public BooksController(Interfaces.IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Model.Book> books = _bookRepository.List();

            return new JsonResult(books);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Model.Book book = _bookRepository.Get(id);
            return new JsonResult(book);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Model.Book book)
        {
            _bookRepository.Insert(book);
            return new JsonResult(book);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Model.Book book)
        {
            _bookRepository.Update(book);
            return new JsonResult(book);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(id);
            return Ok();
        }
    }
}