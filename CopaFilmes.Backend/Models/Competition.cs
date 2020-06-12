namespace CopaFilmes.Backend.Models
{
    public class Competition
    {
        public Film FirstCompetitor { get; private set; }
        public Film SecondCompetitor { get; private set; }

        public Competition(Film firstCompetitor, Film secondCompetitor)
        {
            FirstCompetitor = firstCompetitor;
            SecondCompetitor = secondCompetitor;
        }

        public Film DetermineWinner()
        {
            return FirstCompetitor.Nota > SecondCompetitor.Nota ?
                FirstCompetitor :
                SecondCompetitor;
        }
    }
}