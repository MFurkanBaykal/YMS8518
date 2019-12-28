﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Interfaces.IBookRepository _bookRepository;
        public BookController(Interfaces.IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;   
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _bookRepository.GetAll();
            return new JsonResult(users);
        }
    }
}