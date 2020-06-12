using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class FinalChampionship : Championship
    {
        
        public FinalChampionship(IEnumerable<Film> films, int maxContestants) : base(films, maxContestants) { }

        public override IEnumerable<Film> Compete()
        {
            return Compare(Films.ElementAt(0), Films.ElementAt(1));
        }
    }
}