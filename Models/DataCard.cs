using System.ComponentModel.DataAnnotations.Schema;

namespace Memoroku.Models;

[Table("daily_card")]
public class DataCard
{
    [Column("id")]
    public int Id { get; set; }
    [Column("alt_id")]
    public Guid Alt_Id { get; set; }
    [Column("card_name")]
    public string Card_Name { get; set; }
    [Column("created_date")]
    public DateTime Created_Date { get; set; }
    [Column("num_flash")]
    public int Num_Flash {get; set;}
}