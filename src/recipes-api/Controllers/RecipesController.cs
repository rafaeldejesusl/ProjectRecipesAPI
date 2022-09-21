using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipesController : ControllerBase
{    
    public readonly IRecipeService _service;
    
    public RecipesController(IRecipeService service)
    {
        this._service = service;        
    }

    //Read
    [HttpGet]
    public IActionResult Get()
    {
        var result = _service.GetRecipes();
        return Ok(result);    
    }

    //Read
    [HttpGet("{name}", Name = "GetRecipe")]
    public IActionResult Get(string name)
    {                
        var result = _service.GetRecipe(name);
        if (result is null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create([FromBody]Recipe recipe)
    {
        if (recipe is null) return BadRequest();
        _service.AddRecipe(recipe);
        return CreatedAtAction("GetRecipe", new { name = recipe.Name }, recipe);
    }

    [HttpPut("{name}")]
    public IActionResult Update(string name, [FromBody]Recipe recipe)
    {
        if (recipe is null || name != recipe.Name) return BadRequest();
        _service.UpdateRecipe(recipe);
        return NoContent();
    }

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        bool check = _service.RecipeExists(name);
        if (!check) return NotFound();
        _service.DeleteRecipe(name);
        return NoContent();
    }    
}
