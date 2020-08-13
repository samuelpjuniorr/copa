using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaApi.Domain.Interfaces.Service;
using CopaApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Copa.Controllers
{
    [ApiController]
    [Route("api/equipe")]
    public class EquipeController : ControllerBase
    {
        private readonly IEquipeService _equipeService;

        public EquipeController(IEquipeService equipeService)
        {
            _equipeService = equipeService;
        }


        [HttpGet("listar")]
        public ActionResult<List<Equipe>> Listar()
        {
            try
            {


                return Ok(_equipeService.RegatarEquipesWS());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
