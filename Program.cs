public class Program
{
    public static void Main(string[] args)
    {
        Game PUBG = new Game()
        {
            Title = "PlayerUnknown's Battlegrounds",
            Genre = "Battle Royale",
            Developer = "PUBG Corporation",
            Publisher = "PUBG Corporation",
            ReleaseYear = 2017,
            Platform = "PC, PS4, Xbox, iOS, Android",
            Rating = 8.0,
            IsMultiplayer = true,
            Price = 29.99,
            DownloadSize = 40
        };
        PUBG.DisplayInfo();
        PUBG.DisplayRating();
        Console.WriteLine();
        
        Game GTA = new Game()
        {
            Title = "Grand Theft Auto V (GTA V)",
            Genre = "Action-Adventure",
            Developer = "Rockstar North",
            Publisher = "Rockstar Games",
            ReleaseYear = 2013,
            Platform = "PC, PS3, PS4, PS5, Xbox 360, Xbox One, Xbox Series X/S",
            Rating = 9.7,
            IsMultiplayer = true,
            Price = 29.99,
            DownloadSize = 94
        };
        GTA.DisplayInfo();
        GTA.DisplayRating();
    }
}