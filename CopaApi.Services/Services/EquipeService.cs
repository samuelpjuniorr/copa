using CopaApi.Domain.Interfaces.Repository;
using CopaApi.Domain.Interfaces.Service;
using CopaApi.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CopaApi.Services.Services
{
    public class EquipeService : BaseService<Equipe>, IEquipeService
    {

        private readonly IEquipeRepository _equipeRepository;
        public EquipeService(IEquipeRepository equipeRepository)
           : base(equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        /// <summary>
        /// Resgatar Equipes WS
        /// </summary>
        /// <returns>List<Equipe></returns>
        public List<Equipe> RegatarEquipesWS()
        {
            try
            {
                string urlService = "https://raw.githubusercontent.com/delsonvictor/testetecnico/master/equipes.json";
                var client = new RestClient(urlService);


                var request = new RestRequest("", Method.GET);                  

                var response = client.Get(request);

                List<Equipe> listaEquipe = JsonConvert.DeserializeObject<List<Equipe>>(response.Content);

                return listaEquipe;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
