using CopaApi.Domain.Models;
using CopaApi.Infra.Repositories;
using CopaApi.Services.Services;
using CopaApi.Test.Mocks;
using System;
using System.Collections.Generic;
using Xunit;

namespace CopaApi.Test.Services
{
    public class EquipeServiceTest
    {
        [Fact]
        public void RegatarEquipesWS()
        {
            //Arrange
            var equipeRepository = new MockEquipeRepository();
            var equipeService = new EquipeService(equipeRepository.Object);

            //Act
            var resultado = equipeService.RegatarEquipesWS();
            //Assert
            // Verifica se o retorno não é null
            Assert.NotNull(resultado);
            Assert.IsAssignableFrom<List<Equipe>>(resultado);
        }
    }
}
