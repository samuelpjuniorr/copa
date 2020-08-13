using CopaApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Domain.Interfaces.Service
{
    public interface IEquipeService : IBaseService<Equipe>
    {

        /// <summary>
        /// Resgatar Equipes WS
        /// </summary>
        /// <returns>List<Equipe></returns>
        List<Equipe> RegatarEquipesWS();
    }
}
