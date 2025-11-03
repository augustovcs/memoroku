using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Memoroku.Models;
[Table("flash_list")]
public class DataFlash
{
    [Column("id")]
    public Guid Id { get; set; }
    [Column("card_id")]
    public int CardId { get; set; }
    [Column("flash_string")]
    public string FlashString { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}