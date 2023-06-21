using CategoryCrud.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrud.Model
{
    public class CategoryRepository
    {
        private readonly DataContext context;
        public CategoryRepository(DataContext context) {
            this.context = context;
        }
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<ActionResult<Category?>> GetOne(int id)
        {
            return await context.Categories.FindAsync(id);
        }

        public async void Add(Category category)
        {
            context.Categories.Add(category);
            await context.SaveChangesAsync();
        }

        public async void Update(Category updatedCategory)
        {
            Category? category = await context.Categories.FindAsync(updatedCategory.Id);
            if (category != null)
            {
                category.Name = updatedCategory.Name;
                category.Slug = updatedCategory.Slug;
                category.Image = updatedCategory.Image;
                category.Status = updatedCategory.Status;
                category.UpdatedTime = DateTime.Now;

                await context.SaveChangesAsync();
            }
        }

        public async void Delete(int id)
        {
            Category? category = await context.Categories.FindAsync(id);
            if (category != null)
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
            }
        }
    }
}
