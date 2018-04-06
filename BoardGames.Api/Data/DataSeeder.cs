using BoardGames.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BoardGames.Api.Data
{
    public static class DataSeeder
    {
        public static void SeedGames(GamesDbContext dbContext)
        {
            dbContext.Database.Migrate();

            if (dbContext.Games.Any())
            {
                return;
            }

            var games = new List<Game>
            {
                new Game
                {
                    Title = "7 Wonders",
                    Year = 2010,
                    Rating = 7.8m,
                    Age = "10+",
                    Players = "2-7",
                    PlayingTime ="30 min",
                    Designer = "Antoine Bauza",
                    Publisher = "Repos Production",
                    Url = "https://boardgamegeek.com/boardgame/68448/7-wonders",
                    Image = "7-wonders.jpg",
                    Types = "family,strategy"
                },
                new Game
                {
                    Title = "Anachrony",
                    Year = 2017,
                    Rating = 8.2m,
                    Age = "15+",
                    Players = "1-4",
                    PlayingTime ="45-150 min",
                    Designer = "David Turzi",
                    Publisher = "Mindclash Games",
                    Url = "https://boardgamegeek.com/boardgame/185343/anachrony",
                    Image = "anachrony.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Burgle Bros",
                    Year = 2015,
                    Rating = 7.7m,
                    Age = "12+",
                    Players = "1-4",
                    PlayingTime ="90 min",
                    Designer = "Tim Fowers",
                    Publisher = "Fower Games",
                    Url = "https://boardgamegeek.com/boardgame/172081/burgle-bros",
                    Image = "burgle-bros.jpg",
                    Types = "family,thematic"
                },
                new Game
                {
                    Title = "Carcassonne",
                    Year = 2000,
                    Rating = 7.4m,
                    Age = "8+",
                    Players = "2-5",
                    PlayingTime ="30-45 min",
                    Designer = "Klaus-Juergen Wrede",
                    Publisher = "Z-Man Games",
                    Url = "https://boardgamegeek.com/boardgame/822/carcassonne",
                    Image = "carcassonne.jpg",
                    Types = "family"
                },
                new Game
                {
                    Title = "Caverna",
                    Year = 2013,
                    Rating = 8.2m,
                    Age = "12+",
                    Players = "1-7",
                    PlayingTime ="30-210 min",
                    Designer = "Uwe Rosenberg",
                    Publisher = "Myfair Games",
                    Url = "https://boardgamegeek.com/boardgame/102794/caverna-cave-farmers",
                    Image = "caverna-cave-farmers.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Codenames",
                    Year = 2015,
                    Rating = 7.9m,
                    Age = "14+",
                    Players = "2-8",
                    PlayingTime ="15 min",
                    Designer = "Vlaada Chvatil",
                    Publisher = "Czech Games Edition",
                    Url = "https://boardgamegeek.com/boardgame/178900/codenames",
                    Image = "codenames.jpg",
                    Types = "party"
                },
                new Game
                {
                    Title = "Eldritch Horror",
                    Year = 2013,
                    Rating = 7.9m,
                    Age = "14+",
                    Players = "2-8",
                    PlayingTime ="120-240 min",
                    Designer = "Corey Konieczka, Nikki Valens",
                    Publisher = "Fantasy Flight Games",
                    Url = "https://boardgamegeek.com/boardgame/146021/eldritch-horror",
                    Image = "eldritch-horror.jpg",
                    Types = "thematic"
                },
                new Game
                {
                    Title = "Flash Point: Fire Rescue",
                    Year = 2011,
                    Rating = 7.3m,
                    Age = "10+",
                    Players = "1-6",
                    PlayingTime ="45 min",
                    Designer = "Kevin Lanzing",
                    Publisher = "Indie Boards & Cards",
                    Url = "https://boardgamegeek.com/boardgame/100901/flash-point-fire-rescue",
                    Image = "flash-point-fire-rescue.jpg",
                    Types = "family,thematic"
                },
                new Game
                {
                    Title = "Gloomhaven",
                    Year = 2017,
                    Rating = 9.0m,
                    Age = "12+",
                    Players = "1-4",
                    PlayingTime ="90-150 min",
                    Designer = "Isaac Childres",
                    Publisher = "Cephalofair Games",
                    Url = "https://boardgamegeek.com/boardgame/174430/gloomhaven",
                    Image = "gloomhaven.jpg",
                    Types = "strategy,thematic"
                },
                new Game
                {
                    Title = "Love Letter",
                    Year = 2012,
                    Rating = 7.3m,
                    Age = "10+",
                    Players = "2-4",
                    PlayingTime ="20 min",
                    Designer = "Seiji Kanai",
                    Publisher = "AEG",
                    Url = "https://boardgamegeek.com/boardgame/129622/love-letter",
                    Image = "love-letter.jpg",
                    Types = "family"
                },
                new Game
                {
                    Title = "King of Tokyo",
                    Year = 2011,
                    Rating = 7.3m,
                    Age = "8+",
                    Players = "2-6",
                    PlayingTime ="30 min",
                    Designer = "Richard Garfield",
                    Publisher = "Iello",
                    Url = "https://boardgamegeek.com/boardgame/70323/king-tokyo",
                    Image = "king-of-tokyo.jpg",
                    Types = "family"
                },
                new Game
                {
                    Title = "Kingdom Death: Monster",
                    Year = 2015,
                    Rating = 8.8m,
                    Age = "17+",
                    Players = "1-6",
                    PlayingTime ="60-180 min",
                    Designer = "Adam Poots",
                    Publisher = "Kingdom Death",
                    Url = "https://boardgamegeek.com/boardgame/55690/kingdom-death-monster",
                    Image = "kingdom-death-monster.jpg",
                    Types = "thematic"
                },
                new Game
                {
                    Title = "Pandemic Legacy: Season 1",
                    Year = 2015,
                    Rating = 8.7m,
                    Age = "13+",
                    Players = "2-4",
                    PlayingTime ="60 min",
                    Designer = "Rob Daviau, Matt Leacock",
                    Publisher = "Z-Man Games",
                    Url = "https://boardgamegeek.com/boardgame/161936/pandemic-legacy-season-1",
                    Image = "pandemic-legacy-season-1.jpg",
                    Types = "strategy,thematic"
                },
                new Game
                {
                    Title = "Patchwork",
                    Year = 2014,
                    Rating = 7.8m,
                    Age = "8+",
                    Players = "2",
                    PlayingTime ="15-30 min",
                    Designer = "Uwe Rosenberg",
                    Publisher = "Mayfair Games",
                    Url = "https://boardgamegeek.com/boardgame/163412/patchwork",
                    Image = "patchwork.jpg",
                    Types = "family,abstract"
                },
                new Game
                {
                    Title = "Paperback",
                    Year = 2014,
                    Rating = 7.4m,
                    Age = "8+",
                    Players = "2-5",
                    PlayingTime ="45 min",
                    Designer = "Tim Fowers",
                    Publisher = "Fowers Games",
                    Url = "https://boardgamegeek.com/boardgame/141572/paperback",
                    Image = "paperback.jpg",
                    Types = "family,strategy"
                },
                new Game
                {
                    Title = "Race for the Galaxy",
                    Year = 2007,
                    Rating = 7.8m,
                    Age = "12+",
                    Players = "2-4",
                    PlayingTime ="30-60 min",
                    Designer = "Thomas Lehmann",
                    Publisher = "Rio Grande Games",
                    Url = "https://boardgamegeek.com/boardgame/28143/race-galaxy",
                    Image = "race-galaxy.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Raiders of the North Sea",
                    Year = 2015,
                    Rating = 7.8m,
                    Age = "12+",
                    Players = "2-4",
                    PlayingTime ="60-120 min",
                    Designer = "Shem Phillips",
                    Publisher = "Garphill Games",
                    Url = "https://boardgamegeek.com/boardgame/170042/raiders-north-sea",
                    Image = "raiders-north-sea.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Robinson Crusoe: Adventures of the Cursed Island",
                    Year = 2012,
                    Rating = 8.0m,
                    Age = "14+",
                    Players = "1-4",
                    PlayingTime ="90-180 min",
                    Designer = "Ignacy Trzewiczek",
                    Publisher = "Portal Games",
                    Url = "https://boardgamegeek.com/boardgame/121921/robinson-crusoe-adventures-cursed-island",
                    Image = "robinson-crusoe.jpg",
                    Types = "thematic"
                },
                new Game
                {
                    Title = "Scythe",
                    Year = 2016,
                    Rating = 8.3m,
                    Age = "14+",
                    Players = "1-5",
                    PlayingTime ="90-115 min",
                    Designer = "Jamey Stagmaier",
                    Publisher = "Stonemaier Games",
                    Url = "https://boardgamegeek.com/boardgame/169786/scythe",
                    Image = "scythe.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Star Realms",
                    Year = 2014,
                    Rating = 7.6m,
                    Age = "12+",
                    Players = "2",
                    PlayingTime ="20 min",
                    Designer = "Robert Dougherty, Darwin Kastle",
                    Publisher = "Iello",
                    Url = "https://boardgamegeek.com/boardgame/147020/star-realms",
                    Image = "star-realms.jpg",
                    Types = "strategy"
                },
                new Game
                {
                    Title = "Splendor",
                    Year = 2014,
                    Rating = 7.5m,
                    Age = "10+",
                    Players = "2-4",
                    PlayingTime ="30 min",
                    Designer = "Marc Andre",
                    Publisher = "Space Cowboys",
                    Url = "https://boardgamegeek.com/boardgame/148228/splendor",
                    Image = "splendor.jpg",
                    Types = "family"
                },
                new Game
                {
                    Title = "Ticket to Ride: Europe",
                    Year = 2005,
                    Rating = 7.6m,
                    Age = "8+",
                    Players = "2-5",
                    PlayingTime ="30-60 min",
                    Designer = "Alan R. Moon",
                    Publisher = "Days of Wonder",
                    Url = "https://boardgamegeek.com/boardgame/14996/ticket-ride-europe",
                    Image = "ticket-ride-europe.jpg",
                    Types = "family"
                },
                new Game
                {
                    Title = "Tiny Epic Galaxies",
                    Year = 2015,
                    Rating = 7.4m,
                    Age = "14+",
                    Players = "1-5",
                    PlayingTime ="30-60 min",
                    Designer = "Scott Almes",
                    Publisher = "Gamelyn Games",
                    Url = "https://boardgamegeek.com/boardgame/163967/tiny-epic-galaxies",
                    Image = "tiny-epic-galaxies.jpg",
                    Types = "strategy"
                }
            };

            dbContext.Games.AddRange(games);
            dbContext.SaveChanges();
        }
    }
}
