using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Cookbook.Models;

namespace Cookbook.Controllers
{
    public class RecipeController : Controller
    {
        public RecipeRepository _repository;

        public RecipeController() {
            _repository = new RecipeRepository();
        }

        public IActionResult Index()
        {
            var recipes = _repository.GetAllRecipes();
            return View(recipes);
        }

        /*public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Recipe recipe)
        {
            recipe.ID = recipes.Count + 1;
            recipes.Add(recipe);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var recipe = recipes.Find(r => r.ID == id);
            if (recipe == null)
                return NotFound();
            return View(recipe);
        }*/

         public IActionResult Edit(int id)
        {
            var recipes = _repository.GetAllRecipes();
            var recipe = recipes.Find(r => r.ID == id);
            if (recipe == null)
                return NotFound();
            return View(recipe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Recipe recipe)
        {
            _repository.UpdateRecipe(recipe);
            return RedirectToAction(nameof(Index));
        }

        /*public IActionResult Delete(int id)
        {
            var recipe = recipes.Find(r => r.ID == id);
            if (recipe == null)
                return NotFound();
            recipes.Remove(recipe);
            return RedirectToAction("Index");
        }*/
    }
}
