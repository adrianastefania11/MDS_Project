﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.PullRecipeRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PullRecipeController : ControllerBase
    {
        private readonly IPullRecipeRepository _repository;
        public PullRecipeController(IPullRecipeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPullRecipes()
        {
            var PullRecipes = await _repository.GetAllPullRecipes();

            var PullRecipesToReturn = new List<PullRecipeDTO>();

            foreach (var q in PullRecipes)
            {
                PullRecipesToReturn.Add(new PullRecipeDTO(q));
            }

            return Ok(PullRecipesToReturn);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePullRecipeType(int id)
        {
            var PullRecipe = await _repository.GetByIdAsync(id);

            if (PullRecipe == null)
            {
                return NotFound("PullRecipe does not exist!");
            }

            _repository.Delete(PullRecipe);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreatePullRecipe(CreatePullRecipeDTO dto)
        {
            PullRecipe newPullRecipe = new PullRecipe();

   
            _repository.Create(newPullRecipe);

            await _repository.SaveAsync();


            return Ok(new PullRecipeDTO(newPullRecipe));
        }
    }
}
