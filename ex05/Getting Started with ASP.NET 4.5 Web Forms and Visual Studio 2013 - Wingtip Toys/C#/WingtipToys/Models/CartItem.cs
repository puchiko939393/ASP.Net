using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
  public class CartItem
  {
    [Key]//Primary Key of the table
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public int Quantity { get; set; }

    public System.DateTime DateCreated { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; }

  }
}