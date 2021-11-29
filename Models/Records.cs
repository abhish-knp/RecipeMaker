using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RecipeMaker.Models
{
    public record Recipes
    {
        
        [JsonProperty("recipe_id")]
        public string RecipeId { get; set; }    

        [Required]
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Direction { get; init; }
        public IEnumerable<string> Tags { get; init; }

        [Required]
        public IEnumerable<string> Ingredients { get; init; }
        public DateTime Updated { get; init; }  
    }
    public record Ingredint
    {
        [Required]
        public string Name { get; init; }
        public string Amount { get; init; }
        public string Unit { get; init; }   
    }
}
