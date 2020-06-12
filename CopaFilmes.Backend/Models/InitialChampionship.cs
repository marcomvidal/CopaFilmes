using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class InitialChampionship : Championship
    {
        
        public InitialChampionship(IEnumerable<Film> films, int maxContestants) : base(films, maxContestants) { }

        public override IEnumerable<Film> Compete()
        {
            return Compare(Films.Take(Matches), Films.Reverse().Take(Matches));
        }
    }
}