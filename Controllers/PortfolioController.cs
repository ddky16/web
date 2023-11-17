using MyWebsite.Blazor.Model;

namespace MyWebsite.Blazor.Controllers
{
    public class PortfolioController
    {
        private List<Portfolio> Portfolios = new List<Portfolio>();

        public void SetPortfolio()
        {
            var portfolio1 = new Portfolio()
            {
                Title = "Platus Javanicus",
                Description = "A game education based on license plate number and culture around Java Island. This game is awarded as Finalist Game Development at Pagelaran Mahasiswa Nasional Bidang Teknologi Informasi dan Komunikasi (GemasTIK) XIII 2020",
                ImagePath = "./images/portfolio/platus-javanicus.png",
                Link = "https://patebastudio.itch.io/platus-javanicus"
            };

            var portfolio2 = new Portfolio()
            {
                Title = "Batita",
                Description = "A multiplayer co-op, platformer game based on Aksara Jawa story. Batita is an abbreviation of Bara & Tirta. Bara is the name of the Fire element character and Tirta is the name of the Water element character. This game has a scenario or background on the island of Java by also raising elements of Javanese culture such as ancient buildings, Javanese script, and hanacaraka stories which we have tried to implement by changing the storyline but not leaving the meaning of hanacaraka.",
                ImagePath = "./images/portfolio/batita.png",
                Link = "https://patebastudio.itch.io/batita-adventure"
            };

            var portfolio3 = new Portfolio()
            {
                Title = "The Cheese Tax",
                Description = "It's night time in a medieval tavern and the humans are gone. Now the rats come out to scavenge food. Explore and eat all the cheese on the map but keep an eye on your hunger! Freeload off the humans and eat all their food to win. (beware: you are a VERY hungry rat)",
                ImagePath = "./images/portfolio/the-cheese-tax.png",
                Link = "https://widwicky.itch.io/the-cheese-tax"
            };

            var portfolio4 = new Portfolio()
            {
                Title = "Warta Ekonomi Awards",
                Description = "An virtual tour who presented the warta ekonomi about the digital finance in Indonesia.",
                ImagePath = "./images/portfolio/warta-ekonomi-awards.png",
                Link = "https://atlasunity.github.io/warta-ekonomi-awards/"
            };

            Portfolios.Add(portfolio1);
            Portfolios.Add(portfolio2);
            Portfolios.Add(portfolio3);
            Portfolios.Add(portfolio4);
        }

        public List<Portfolio> GetPortfolios => Portfolios;
    }
}
