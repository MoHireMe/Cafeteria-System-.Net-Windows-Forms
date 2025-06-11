using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BuisnessLayer.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository cat)
        {
            _categoryRepository = cat;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id) {

            if (id <= 0)
            {
                throw new ArgumentException("Category ID must be greater than zero.", nameof(id));
            }
            return _categoryRepository.GetCategoryById(id);
        }

        public void AddCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            _categoryRepository.AddCategory(category);
        }
        public void UpdateCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            _categoryRepository.UpdateCategory(category);
        }
        public void DeleteCategory(int id)
        {

        }
    }
}
