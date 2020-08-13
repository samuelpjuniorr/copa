using CopaApi.Domain.Interfaces.Repository;
using CopaApi.Domain.Interfaces.Service;
using CopaApi.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CopaApi.Services.Services
{
    public class CopaService : BaseService<Copa>, ICopaService
    {

        private readonly ICopaRepository _copaRepository;
        private readonly IEquipeService _equipeService;
        public CopaService(ICopaRepository copaRepository, IEquipeService equipeService)
           : base(copaRepository)
        {
            _copaRepository = copaRepository;
            _equipeService = equipeService;
        }

        /// <summary>
        /// Obter o resultado da copa
        /// </summary>
        ///<param name="equipesParticipantes">equipesParticipantes</param>
        /// <returns>Copa</returns>
        public Copa ObterResultado(List<Equipe> equipesParticipantes)
        {
            try
            {
                equipesParticipantes = equipesParticipantes.OrderBy(x => x.Nome).ToList();
                Copa copaTeste = new Copa
                {
                    EquipesParticipantes = equipesParticipantes,
                    Nome = "Copa Teste",

                };

                return copaTeste;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
