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
            var winners = new List<Film>();
            
            for (int i = 0; i < Matches; i++)
            {
                var competition = new Competition(firstHalf.ElementAt(i), secondHalf.ElementAt(i));
                winners.Add(competition.DetermineWinner());
            }

            return winners;
        }

        public IEnumerable<Film> Compare(Film firstFilm, Film secondFilm)
        {
            var competition = new Competition(firstFilm, secondFilm);

            return competition.DetermineWinner() == firstFilm ?
                new List<Film> { firstFilm, secondFilm } :
                new List<Film> { secondFilm, firstFilm };
        }
    }
}