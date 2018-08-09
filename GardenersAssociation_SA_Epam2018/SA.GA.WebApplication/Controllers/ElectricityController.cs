﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SA.GA.Business.Services;
using SA.GA.Common.Models;

namespace SA.GA.WebApplication.Controllers
{
    [Route("api/electricitys")]
    public class ElectricityController : Controller
    {
        private readonly IElectricityService _electricityService;

        public ElectricityController(IElectricityService electricityService)
        {
            _electricityService = electricityService;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Electricity electricity = _electricityService.GetElectricitysList().FirstOrDefault(x => x.Id == id);
            if (electricity != null)
            {
                _electricityService.DeleteElectricityByElectricityId(id);
            }
            return Ok(electricity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Electricity electricity)
        {
            if (ModelState.IsValid)
            {
                _electricityService.UpdateElectricity(electricity);
                return Ok(electricity);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Electricity electricity)
        {
            if (ModelState.IsValid)
            {
                _electricityService.SaveElectricity(electricity);
                return Ok(electricity);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public Electricity Get(int id)
        {
            Electricity electricity = _electricityService.GetElectricityById(id);
            return electricity;
        }

        [HttpGet]
        public IEnumerable<Electricity> Get()
        {
            return _electricityService.GetElectricitysList();
        }
    }
}