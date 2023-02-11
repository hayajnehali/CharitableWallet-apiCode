using Dapper;
using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository//
    {
        private readonly IDbContext dbContext;
        public CategoryRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CREATECategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("categoryName", category.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("categoryImage", category.Categoryimage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_desc1", category.CategoryDesc, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_paragraph1", category.CategoryParagraph, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Category_P.CREATECategory", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Category_P.DeleteCategory", p, commandType: CommandType.StoredProcedure);

        }

        public List<Category> GetAllCategory()
        {
          
            IEnumerable<Category> users = dbContext.Connection.Query<Category>("Category_P.GetAllCategory", commandType: CommandType.StoredProcedure);
            return users.ToList();
           
        }

        public Category GetCategoryById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Category> users = dbContext.Connection.Query<Category>("Category_P.GetCategoryById", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }

        public void UPDATECategory(Category category)
        {
            var p = new DynamicParameters();

            p.Add("categoryID1", category.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("categoryNames1", category.Categoryname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("categoryImages1", category.Categoryimage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_descs1", category.CategoryDesc, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_paragraphs1", category.CategoryParagraph, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Category_P.UPDATECategory", p, commandType: CommandType.StoredProcedure);

        }
    }
}
