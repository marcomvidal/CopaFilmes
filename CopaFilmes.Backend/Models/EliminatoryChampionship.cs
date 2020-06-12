using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class EliminatoryChampionship : Championship
    {
        
        public EliminatoryChampionship(IEnumerable<Film> films, int maxContestants) : base(films, maxContestants) { }

        public override IEnumerable<Film> Compete()
        {
            return Compare(
                Films.Where((film, index) => index % 2 == 0),
                Films.Where((film, index) => index % 2 == 1));
        }
    }
}