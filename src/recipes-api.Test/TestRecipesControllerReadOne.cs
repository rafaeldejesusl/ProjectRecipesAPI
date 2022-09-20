using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System;
using recipes_api.Models;
using recipes_api.Services;
using recipes_api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace recipes_api.Test;

public class TestRecipesControllerReadOne
{
    public static IEnumerable<object[]> RecipeServiceTestData()
    {
        throw new NotImplementedException();        
    }

    [Theory]
    [MemberData(nameof(RecipeServiceTestData))]
    public void TestReadOne(string entryName, Recipe expected)
    {
        throw new NotImplementedException();
    }
}