using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public abstract class Phase
    {
        public int Matches { get; private set; }

        public Phase(int maxContestants)
        {
            Matches = maxContestants / 2;
        }

        public abstract IEnumerable<Film> DetermineWinners(IEnumerable<Film> films);

        public IEnumerable<Film> Compare(Film firstFilm, Film secondFilm)
        {
            var competition = new Competition(firstFilm, secondFilm);

            return competition.DetermineWinner() == firstFilm ?
                new List<Film> { firstFilm, secondFilm } :
                new List<Film> { secondFilm, firstFilm };
        }

        protected void ValidateNumberOfContestants(IEnumerable<Film> films)
        {
            int contestants = Matches * 2;

            if (films.Count() != contestants)
            {
                throw new ArgumentOutOfRangeException(
                    $"This phase of the championship requires exactly {contestants} films to happen.");
            }
        }

        protected IEnumerable<Film> Compare(IEnumerable<Film> firstHalf, IEnumerable<Film> secondHalf)
        {
            return firstHalf.Zip(secondHalf, (first, second) =>
            {
                var competition = new Competition(first, second);
                return competition.DetermineWinner();
            });
        }
    }
}