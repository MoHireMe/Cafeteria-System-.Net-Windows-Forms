using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        // GET methods
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        
        // Set methods
        void AddCategory(Category category);
        
        // Update methods
        void UpdateCategory(Category category);
        
        // Delete methods
        void DeleteCategory(int catId);
    }
}
