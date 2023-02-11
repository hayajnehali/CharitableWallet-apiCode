using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            this.categoryService = _categoryService;
        }

        [HttpGet("GetAllCategory")]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }

        [HttpPost("CREATECategory")]
        public void CREATECategory([FromBody] Category document)
        {
            
            categoryService.CREATECategory(document);
        }

        [HttpPut("UPDATECategory")]
        public void UPDATECategory([FromBody] Category document)
        {
            categoryService.UPDATECategory(document);
        }

        [HttpGet("GetCategoryById/{id}")]
        public Category GetCategoryById(int id)
        {
            return categoryService.GetCategoryById(id);
        }
        [HttpDelete("DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            categoryService.DeleteCategory(id);
        }

        [Route("UploadImages")]
        [HttpPost]

        //D:\Desktop\Charity-Platform-team\src\assets\img FERAS
        public Category UploadImage()
        {
            var file = Request.Form.Files[0];
            var filename = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\Users\\user\\Desktop\\tahaluf\\finalproject\\====f-p-13-1\\Charity-Platform-team\\src\\assets\\img", filename);
            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Category item = new Category();
            item.Categoryimage = filename;
            return item;
        }

    }

    
}
