using Xunit;
using CopaFilmes.Backend.Models;
using System.Collections.Generic;
using CopaFilmes.Backend.Repositories;
using CopaFilmes.Backend.Services;
using Moq;
using System.Net.Http;

namespace CopaFilmes.Test.Repositories
{
    public class FilmsServiceTest
    {
        [Fact]
        public void GetWinners_Success()
        {
            var expectedWinners = new List<Film>
            {
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 },
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 }
            };

            var repository = new Mock<IFilmsRepository>();
            repository
                .Setup(repo => repo.AllWinners())
                .Returns(expectedWinners);

            var service = new FilmsService(repository.Object, new HttpClient());
            var actualWinners = service.GetWinners();

            Assert.Equal(expectedWinners, actualWinners);
        }
    }
}