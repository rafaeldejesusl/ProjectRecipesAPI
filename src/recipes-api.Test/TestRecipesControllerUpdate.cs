using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System;
using recipes_api.Models;
using recipes_api.Services;
using recipes_api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace recipes_api.Test;

public class TestRecipesControllerUpdate
{
    public static IEnumerable<object[]> RecipeServiceTestData()
    {
        throw new NotImplementedException();        
    }

    [Theory]
    [MemberData(nameof(RecipeServiceTestData))]
    public void TestUpdate(string entryName, Recipe entryRecipe, List<Recipe> expected)
    {
        throw new NotImplementedException();
    }
}