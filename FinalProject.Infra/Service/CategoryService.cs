using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository _categoryRepository)
        {
            this.categoryRepository = _categoryRepository;
        }
        public void CREATECategory(Category category)
        {
            categoryRepository.CREATECategory(category);
        }

        public void DeleteCategory(int id)
        {
            categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetAllCategory()
        {
          return categoryRepository.GetAllCategory();
        }

        public Category GetCategoryById(int id)
        {
            return categoryRepository.GetCategoryById(id);
        }

        public void UPDATECategory( Category category)
        {
            categoryRepository.UPDATECategory( category);    
        }
    }
}
