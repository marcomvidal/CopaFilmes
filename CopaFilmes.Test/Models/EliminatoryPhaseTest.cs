using Xunit;
using CopaFilmes.Backend.Models;
using System.Collections.Generic;
using System;

namespace CopaFilmes.Test.Models
{
    public class EliminatoryPhaseTest
    {
        [Fact]
        public void DetermineWinners_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 6.7 },
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 },
                new Film { Id = "tt3501632", Titulo = "Thor: Ragnarok", Ano = 2017, Nota = 7.9 },
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 }
            };

            var expectedWinners = new List<Film>
            {
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 },
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 }
            };
            
            var phase = new EliminatoryPhase(4);
            var winners = new List<Film>(phase.DetermineWinners(contestants));

            Assert.Equal(expectedWinners, winners);
        }

        [Fact]
        public void DetermineWinnersWithLessThanFourContestants_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 },
                new Film { Id = "tt3778644", Titulo = "Han Solo: Uma História Star Wars", Ano = 2018, Nota = 7.2 }
            };

            var phase = new EliminatoryPhase(4);

            Assert.Throws<ArgumentOutOfRangeException>(() => phase.DetermineWinners(contestants));
        }

        [Fact]
        public void DetermineWinnersWithMoreThanFourContestants_Success()
        {
            var contestants = new List<Film>
            {
                new Film { Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 6.7 },
                new Film { Id = "tt0317705", Titulo = "Os Incríveis 2", Ano = 2004, Nota = 8 },
                new Film { Id = "tt3501632", Titulo = "Thor: Ragnarok", Ano = 2017, Nota = 7.9 },
                new Film { Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8 },
                new Film { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 }
            };

            var phase = new EliminatoryPhase(4);

            Assert.Throws<ArgumentOutOfRangeException>(() => phase.DetermineWinners(contestants));
        }
    }
}