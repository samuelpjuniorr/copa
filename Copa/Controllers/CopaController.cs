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
        public ActionResult<List<Equipe>> Resultado([FromBody] List<Equipe> equipesParticipantes)
        {
            try
            {
                if (equipesParticipantes.Count != 8)
                    throw new Exception("Número inválido de participantes. A copa é composta por 8 equipes.");

                return Ok(_copaService.ObterResultado(equipesParticipantes));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
