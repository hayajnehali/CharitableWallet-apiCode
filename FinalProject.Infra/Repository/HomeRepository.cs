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
    public class HomeRepository : IHomeRepository
    {
        private readonly IDbContext dbContext;
        public HomeRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Homepage> GetAllHome()
        {
            IEnumerable<Homepage> result = dbContext.Connection.Query<Homepage>("Home_P.getAllHome", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void CreateHome(Homepage homepage)
        {
            var p = new DynamicParameters();
            p.Add("para1", homepage.Paraghraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("para2",homepage.Paraghraph2,dbType:DbType.String, direction: ParameterDirection.Input);
            p.Add("img1",homepage.Imagepath1,dbType:DbType.String,direction: ParameterDirection.Input);
            p.Add("img2", homepage.Imagepath2, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Home_P.CreateHome", p, commandType: CommandType.StoredProcedure);

        }
        public void UpdateHome(Homepage homepage)
        {
            var p = new DynamicParameters();
            p.Add("id", homepage.Homeid, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("para1", homepage.Paraghraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("para2", homepage.Paraghraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img1", homepage.Imagepath1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img2", homepage.Imagepath2, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Home_P.UpdateHome", p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteHome(int id)
        {
            var p = new DynamicParameters();
            p.Add("id",id,dbType:DbType.Int32,direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Home_P.DeleteHome", p, commandType: CommandType.StoredProcedure);

        }
        public Homepage GetHomePageById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id",id,dbType:DbType.Int32,direction:ParameterDirection.Input);
            IEnumerable<Homepage> result = dbContext.Connection.Query<Homepage>("Home_P.getHomeByid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }




    }
}
