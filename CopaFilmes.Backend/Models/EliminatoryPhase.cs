using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class EliminatoryPhase : Phase
    {
        public EliminatoryPhase(int maxContestants) : base(maxContestants) { }

        public override IEnumerable<Film> DetermineWinners(IEnumerable<Film> films)
        {
            ValidateNumberOfContestants(films);

            return Compare(
                films.Where((film, index) => index % 2 == 0),
                films.Where((film, index) => index % 2 == 1));
        }
    }
}