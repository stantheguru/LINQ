class ChampionsLeague
{
    public string club { get; set; }
    public string country { get; set; }

    public List<int> yearsWon {get;set;}
}

class EuropaLeague
{
    public string club { get; set; }
    public string country { get; set; }

    public List<int> yearsWon { get; set; }
}

class DataTransform
{
    static void Main()
    {
        List<ChampionsLeague> champions = new List<ChampionsLeague>()
        {
           new ChampionsLeague
        {
            club = "Chelsea",
            country = "Inglaterra",
            yearsWon = new List<int> { 2012, 2020,2022,2023 }

        },

        new ChampionsLeague
        {
            club = "Real Madrid",
            country = "Espana",
            yearsWon = new List<int> { 1950, 1956, 2011, 2015, 2016 }
        },

        new ChampionsLeague
        {
            club = "Bayern Munchen",
            country = "Alemania",
            yearsWon = new List<int> { 1970, 1980, 1019 }
        }

    };

        List<EuropaLeague> europa = new List<EuropaLeague>()
    {
        new EuropaLeague
        {
            club = "Arsenal",
            country = "Inglaterra",
            yearsWon = new List<int> { 1920, 2003, 2004 }
        },

        new EuropaLeague
        {
            club = "Manchester United",
            country="Inglaterra",
            yearsWon=new List<int> { 1900,2007,2008}
        },

        new EuropaLeague
        {
        club = "Roma",
        country = "Italia",
        yearsWon = new List<int> { 2009 }
        }
    };

        var clubs = (from c in champions
                               where c.yearsWon.Count() <= 3
                               select (c.club)).
                               Concat(from e in europa
                                      where e.club.StartsWith("A")
                                      select e.club);

        foreach(var c in clubs)
        {
            Console.WriteLine("Meet your clubs: " + c);
        }
    }
}