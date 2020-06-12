using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class FinalPhase : Phase
    {
        public FinalPhase(int maxContestants) : base(maxContestants) { }

        public override IEnumerable<Film> DetermineWinners(IEnumerable<Film> films)
        {
            ValidateNumberOfContestants(films);
            
            return Compare(films.ElementAt(0), films.ElementAt(1));
        }
    }
}