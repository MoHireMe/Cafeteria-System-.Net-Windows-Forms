using DAL.Data;
using DAL.Repository.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get methods

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Category.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Category.FirstOrDefault(c => c.Id == id);
        }
        // Set methods
        public void AddCategory(Category category)
        {
           _context.Category.Add(category);
           _context.SaveChanges();
        }
        // Update methods
        public void UpdateCategory(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
        // Delete methods
        public void DeleteCategory(int catId)
        {
            _context.Category.Remove(GetCategoryById(catId));
            _context.SaveChanges();
        }

    }
}
