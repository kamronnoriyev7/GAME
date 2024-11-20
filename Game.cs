
public class Game
{
    public string Title { get; set; } 
    
    public string Genre { get; set; } 
    
    public string Developer { get; set; } 
    
    public string Publisher { get; set; } 
    
    public int ReleaseYear { get; set; }
    
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