using CopaApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Domain.Interfaces.Service
{
    public interface ICopaService : IBaseService<Copa>
    {

        /// <summary>
        /// Obter o resultado da copa
        /// </summary>
        ///<param name="equipesParticipantes">equipesParticipantes</param>
        /// <returns>Copa</returns>
        Copa ObterResultado(List<Equipe> equipesParticipantes);
    }
}
