using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class InitialPhase : Phase
    {
        public InitialPhase(int maxContestants) : base(maxContestants) { }

        public override IEnumerable<Film> DetermineWinners(IEnumerable<Film> films)
        {
            ValidateNumberOfContestants(films);
            
            return Compare(films.Take(Matches), films.Reverse().Take(Matches));
        }
    }
}