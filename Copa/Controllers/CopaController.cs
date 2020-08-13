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
    [Route("api/copa")]
    public class CopaController : ControllerBase
    {
        private readonly ICopaService _copaService;

        public CopaController(ICopaService copaService)
        {
            _copaService = copaService;
        }


        [HttpPost("resultado")]
        public ActionResult<List<Equipe>> Resultado(List<Equipe> equipesParticipantes)
        {
            try
            {


                return Ok(_copaService.ObterResultado(equipesParticipantes));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
