using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public abstract class Championship
    {
        public IEnumerable<Film> Films { get; private set; }
        public int MaxContestants { get; private set; }
        public int Matches { get; private set; }

        public Championship(IEnumerable<Film> films, int maxContestants)
        {
            Films = films;
            MaxContestants = maxContestants;
            Matches = MaxContestants / 2;
        }

        public abstract IEnumerable<Film> Compete();

        public IEnumerable<Film> Compare(IEnumerable<Film> firstHalf, IEnumerable<Film> secondHalf)
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