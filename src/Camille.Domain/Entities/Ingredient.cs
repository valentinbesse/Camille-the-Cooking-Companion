using Camille.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Camille.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public IngredientType IngredientType { get; set;}
        
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; }
    }
}