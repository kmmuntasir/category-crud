using Microsoft.AspNetCore.Mvc;

namespace CategoryCrud.Model
{
    public class CategoryService
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            return await categoryRepository.GetAll();
        }

        public async Task<ActionResult<Category?>> GetSingleCategory(int id)
        {
            return await categoryRepository.GetOne(id);
        }

        public void AddCategory(Category category)
        {
            categoryRepository.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            categoryRepository.Delete(id);
        }
    }
}
