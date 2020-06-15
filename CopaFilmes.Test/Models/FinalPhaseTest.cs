using Xunit;
using CopaFilmes.Backend.Models;
using System.Collections.Generic;
using System;

namespace CopaFilmes.Test.Models
{
    public class FinalPhaseTest
    {
        [Fact]
        public void DetermineWinners_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 },
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 }
            };

            var expectedWinners = new List<Film>
            {
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 },
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 }
            };
            
            var phase = new FinalPhase(2);
            var winners = new List<Film>(phase.DetermineWinners(contestants));

            Assert.Equal(expectedWinners, winners);
        }

        [Fact]
        public void DetermineWinnersWithLessThanTwoContestants_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 }
            };

            var phase = new FinalPhase(2);

            Assert.Throws<ArgumentOutOfRangeException>(() => phase.DetermineWinners(contestants));
        }

        [Fact]
        public void DetermineWinnersWithMoreThanTwoContestants_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 },
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 },
                new Film { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 }
            };

            var phase = new FinalPhase(2);

            Assert.Throws<ArgumentOutOfRangeException>(() => phase.DetermineWinners(contestants));
        }
    }
}