
public class Game
{
    public string Title { get; set; } // O'yin nomi
    
    public string Genre { get; set; } // Janr
    
    public string Developer { get; set; } // Dasturchi kompaniya
    
    public string Publisher { get; set; } // Nashriyot
    
    public int ReleaseYear { get; set; } // Chiqish yili
    
    public string Platform { get; set; } 
    
    public double Rating { get; set; } 
    
    public bool IsMultiplayer { get; set; } 
    
    public double Price { get; set; }
    
    public int DownloadSize { get; set; } 

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}\n Genre: {Genre}\n Developer: {Developer}\n Dowland size: {DownloadSize}");
    }

    public void DisplayRating()
    {
        Console.WriteLine($"Rating: {Rating}");
    }
}