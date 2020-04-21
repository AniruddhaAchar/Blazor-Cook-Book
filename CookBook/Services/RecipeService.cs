using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CookBook.Model;
using System.Security.Cryptography.X509Certificates;

namespace CookBook.Services
{
    public class RecipeService
    {
        private readonly IMongoCollection<Recipe> _recipeContext;


        public RecipeService(IRecipeDatabaseSettings settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            var databaseBase = client.GetDatabase(settings.DatabaseName);

            _recipeContext = databaseBase.GetCollection<Recipe>(settings.CollectionName);
        }
        /// <summary>
        /// Get all the recipes in the database.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Recipe>> GetRecipeAsync()
        {
            var result =   await _recipeContext.FindAsync(recipe => true);
            return result.ToList();
        }

        /// <summary>
        /// Get a specific recipe.
        /// </summary>
        /// <param name="id">The Object ID of the recipe</param>
        /// <returns></returns>
        public Recipe Get(string id) =>
            _recipeContext.Find<Recipe>(recipe => recipe._id == id).FirstOrDefault();

        public async Task<Recipe> CreateAsync(Recipe recipe)
        {
           await _recipeContext.InsertOneAsync(recipe);
            return recipe;
        }

        public void Update(string id, Recipe recipeIn) =>
            _recipeContext.ReplaceOne(recipe => recipe._id == id, recipeIn);

        public void Remove(Recipe recipeIn) =>
            _recipeContext.DeleteOne(recipe => recipe._id == recipeIn._id);

        public void Remove(string id) =>
            _recipeContext.DeleteOne(recipe => recipe._id == id);
    }
}
