namespace Memoroku.Models;

public class DataCard
{
    public int Id { get; set; }
    public Guid Alt_Id { get; set; }
    public string Card_Name { get; set; }
    public DateTime Created_Date { get; set; }
    public int Num_Flash {get; set;}
}