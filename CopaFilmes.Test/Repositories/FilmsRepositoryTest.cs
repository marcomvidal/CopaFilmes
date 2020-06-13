using Xunit;
using CopaFilmes.Backend.Models;
using System.Collections.Generic;
using System;
using CopaFilmes.Backend.Repositories;
using Moq;
using Microsoft.Extensions.Caching.Memory;

namespace CopaFilmes.Test.Repositories
{
    public class FilmsRepositoryTest
    {
        [Fact]
        public void AllWinners_Success()
        {
            object expectedWinners = new List<Film>
            {
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 },
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 }
            };

            var memoryCache = new Mock<IMemoryCache>();

            memoryCache
                .Setup(cache => cache.TryGetValue("WinnerFilms", out expectedWinners))
                .Returns(true);
            
            var repository = new FilmsRepository(memoryCache.Object);
            var actualWinners = repository.AllWinners();

            Assert.Equal(expectedWinners, actualWinners);
        }
    }
}