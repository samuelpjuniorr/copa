using CopaApi.Domain.Models;
using CopaApi.Infra.Repositories;
using CopaApi.Services.Services;
using CopaApi.Test.Mocks;
using System;
using System.Collections.Generic;
using Xunit;

namespace CopaApi.Test.Services
{
    public class CopaServiceTest
    {
        [Fact]
        public void ObterResultado()
        {
            //Arrange
            var copaRepository = new MockCopaRepository();
            var equipeService = new MockEquipeService();
            var copaService = new CopaService(copaRepository.Object, equipeService.Object);

            List<Equipe> listaEquipes = new List<Equipe>();

            Equipe equipe1 = new Equipe
            {
                Nome = "Equipe 1",
                Gols = 2,
                Id = "1"
            };
            Equipe equipe2 = new Equipe
            {
                Nome = "Equipe 2",
                Gols = 3,
                Id = "2"
            };

            listaEquipes.Add(equipe1);
            listaEquipes.Add(equipe2);
            //Act
            var resultado = copaService.ObterResultado(listaEquipes);
            //Assert
            // Verifica se o retorno não é null
            Assert.NotNull(resultado);
            Assert.IsAssignableFrom<Copa>(resultado);
        }
    }
}
