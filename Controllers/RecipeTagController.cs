﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.Entities;
using RecipesApp.Entities.CreateDTO;
using RecipesApp.Entities.DTOs;
using RecipesApp.Repositories.RecipeTagRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeTagController : ControllerBase
    {
        private readonly IRecipeTagRepository _repository;
        public RecipeTagController(IRecipeTagRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> GetAllRecipeTags()
        {
            var RecipeTags = await _repository.GetAllRecipeTag();

            var RecipeTagsToReturn = new List<RecipeTagDTO>();

            foreach (var q in RecipeTags)
            {
                RecipeTagsToReturn.Add(new RecipeTagDTO(q));
            }

            return Ok(RecipeTagsToReturn);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeTagType(int id)
        {
            var RecipeTag = await _repository.GetByIdAsync(id);

            if (RecipeTag == null)
            {
                return NotFound("RecipeTag does not exist!");
            }

            _repository.Delete(RecipeTag);

            await _repository.SaveAsync();

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRecipeTag(CreateRecipeTagDTO dto)
        {
            RecipeTag newRecipeTag = new RecipeTag();


            _repository.Create(newRecipeTag);

            await _repository.SaveAsync();


            return Ok(new RecipeTagDTO(newRecipeTag));
        }
    }
}
