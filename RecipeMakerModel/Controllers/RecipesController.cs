using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeMaker.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery]int count )
        {
            Models.Recipes[] recipes = {
                new(){Title = "Oxtail"} ,
                new(){Title = "Curry Chicken" },
                new(){Title = "Dumplings" },
                new(){Title = "Italian Pizza"}
            };
            
            return Ok(recipes.Take(count));
        }


        
        [HttpPost]
        public ActionResult CreateNewRecipes([FromBody] Recipes newRecipe)
        {
            //validate and save to database
            bool badThingsHappened = false;
            if (badThingsHappened)
                return BadRequest();
            return Created("", newRecipe);
        }

        [HttpDelete]    // For Delete all request: [HttpDelete("all")]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if(badThingsHappened)
                return BadRequest();

            return NoContent();
        }
    }

}
