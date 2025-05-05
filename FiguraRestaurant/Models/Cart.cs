using System.ComponentModel.DataAnnotations;

namespace FiguraRestaurant.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public List<Food> Foods {get;set;}
    }
}
