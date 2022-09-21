using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System;
using recipes_api.Models;
using recipes_api.Services;
using recipes_api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace recipes_api.Test;

public class TestRecipesControllerDelete
{
    public static IEnumerable<object[]> RecipeServiceTestData()
    {
        yield return new object[]
        {
            "Coxinha",
            new List<Recipe>
            {
                new Recipe { Name = "Bolo de cenoura", 
                            RecipeType = RecipesType.sweet, 
                            PreparationTime = 0.4, 
                            Ingredients = new List<string> {"1/2 xícara (chá) de óleo", "3 cenouras médias raladas", "4 ovos", "2 xícaras (chá) de açúcar", "2 e 1/2 xícaras (chá) de farinha de trigo", "1 colher (sopa) de fermento em pó"},
                            Directions = "Em um liquidificador, adicione a cenoura, os ovos e o óleo, depois misture. Acrescente o açúcar e bata novamente por 5 minutos. Em uma tigela ou na batedeira, adicione a farinha de trigo e depois misture novamente. Acrescente o fermento e misture lentamente com uma colher. Asse em um forno preaquecido a 180° C por aproximadamente 40 minutos.",
                            Rating = 10},
                new Recipe { Name = "Pudim de Leite", 
                            RecipeType = RecipesType.sweet, 
                            PreparationTime = 1.1, 
                            Ingredients = new List<string> {"1 xícara (chá) de açúcar", "1 lata de leite condensado", "2 latas de leite (medida da lata de leite condensado)", "3 ovos"},
                            Directions = "Bata todos os ingredientes do pudim no liquidificador e despeje na forma reservada. Asse em banho-maria, em forno médio (180º C), por cerca de 1 hora e 30 minutos. Depois de frio, leve para gelar por cerca de 6 horas. Desenforme e sirva a seguir.",
                            Rating = 9}                        
            }
        };     
    }

    [Theory]
    [MemberData(nameof(RecipeServiceTestData))]
    public void TestDelete(string entryName, List<Recipe> expected)
    {
        RecipesController instance = new RecipesController(new RecipeService());        
        var actionResult = instance.Delete(entryName);
        var okResult = actionResult as NoContentResult;
        okResult.Should().BeAssignableTo<NoContentResult>();
        instance._service.GetRecipes().Should().BeEquivalentTo(expected);
    }
}