using System.ComponentModel.DataAnnotations;

namespace FiguraRestaurant.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public List<Food>? Foods { get; set; }


        public double FullPrice { get => Foods.Sum(x => x.Price); }
    }
}
