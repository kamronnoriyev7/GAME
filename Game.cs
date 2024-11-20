
public class Game
{
    public string Title { get; set; } // O'yin nomi
    
    public string Genre { get; set; } // Janr
    
    public string Developer { get; set; } // Dasturchi kompaniya
    
    public string Publisher { get; set; } // Nashriyot
    
    public int ReleaseYear { get; set; } // Chiqish yili
    
    public string Platform { get; set; } // Platforma (PC, PS5, Xbox va boshqalar)
    
    public double Rating { get; set; } // Reyting (masalan, 8.5/10)
    
    public bool IsMultiplayer { get; set; } // Multiplayer rejim mavjudmi
    
    public double Price { get; set; } // Narx (masalan, dollar)
    
    public int DownloadSize { get; set; } // Yuklab olish hajmi (GB)

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}\n Genre: {Genre}\n Developer: {Developer}\n Dowland size: {DownloadSize}");
    }

    public void DisplayRating()
    {
        Console.WriteLine($"Rating: {Rating}");
    }
}