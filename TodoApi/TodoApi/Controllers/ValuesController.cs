﻿using Lamar;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApi.Interfaces;
using TodoApi.Utils;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesService _valuesService;

        public ValuesController()
        {
            var container = new Container(new Registry());

            _valuesService = container.GetInstance<IValuesService>();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _valuesService.GetAllValues();
        }

        // GET api/values/5
        [HttpGet("{index}")]
        public ActionResult<string> Get(int index)
        {
            return _valuesService.GetValueByIndex(index);
        }

        // GET api/values/something
        [HttpGet("{filter}")]
        public ActionResult<string[]> Get(string filter)
        {
            return _valuesService.GetValuesByFilter(filter);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
