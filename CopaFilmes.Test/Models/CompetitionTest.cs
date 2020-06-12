using Xunit;
using CopaFilmes.Backend.Models;

namespace CopaFilmes.Test.Models
{
    public class CompetitionTest
    {
        [Fact]
        public void FirstFilmHasAHigherRating_Success()
        {
            var osIncriveis = new Film { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 };
            var superFly = new Film { Id = "tt7690670", Titulo = "Superfly", Ano = 2018, Nota = 5.1 };

            var competition = new Competition(osIncriveis, superFly);

            Assert.Equal(osIncriveis, competition.DetermineWinner());
        }

        [Fact]
        public void SecondFilmHasAHigherRating_Success()
        {
            var osIncriveis = new Film { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 };
            var superFly = new Film { Id = "tt7690670", Titulo = "Superfly", Ano = 2018, Nota = 5.1 };

            var competition = new Competition(superFly, osIncriveis);

            Assert.Equal(osIncriveis, competition.DetermineWinner());
        }

        [Fact]
        public void FilmsWithSameRating_Success()
        {
            var hereditario = new Film { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 };
            var upgrade = new Film { Id = "tt6499752", Titulo = "Upgrade", Ano = 2018, Nota = 7.8 };

            var competition = new Competition(hereditario, upgrade);

            Assert.Equal(hereditario, competition.DetermineWinner());
        }

        [Fact]
        public void FilmsAreEqual_Success()
        {
            var film = new Film { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 };
            var sameFilm = new Film { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 };

            var competition = new Competition(film, sameFilm);

            Assert.Equal(film, competition.DetermineWinner());
        }
    }
}
