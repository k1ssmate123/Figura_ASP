using System.ComponentModel.DataAnnotations;

namespace FiguraRestaurant.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public FoodCategoryEnum Category { get; set; }

        public double Price { get; set; }

        public List<string> Ingredients { get; set; }

    }
}
