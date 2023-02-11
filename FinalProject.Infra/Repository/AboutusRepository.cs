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
    public class AboutusRepository : IAboutusRepository
    {
        private readonly IDbContext _dbContext;
        public AboutusRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Aboutu> GetAllaboutus()
        {

            IEnumerable<Aboutu> result = _dbContext.Connection.Query<Aboutu>("aboutus_P.GetAllaboutus", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public void CreateAbout(Aboutu aboutu)
        {
            var p = new DynamicParameters();
            p.Add("paraghraph11", aboutu.Paraghraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("paraghraph21", aboutu.Paraghraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath11", aboutu.Imagepath1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath21", aboutu.Imagepath2, dbType: DbType.String, direction: ParameterDirection.Input);
           
            _dbContext.Connection.Execute("aboutus_P.CreateAbout", p, commandType: CommandType.StoredProcedure);

        }


        public void Updateaboutus(Aboutu aboutu)
        {
            var p = new DynamicParameters();
            p.Add("aboutID1", aboutu.Aboutid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("paraghraph11", aboutu.Paraghraph1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("paraghraph21", aboutu.Paraghraph2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath11", aboutu.Imagepath1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath21", aboutu.Imagepath2, dbType: DbType.String, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("aboutus_P.Updateaboutus", p, commandType: CommandType.StoredProcedure);

        }


        public void Deleteaboutus(int id)
        {
            var p = new DynamicParameters();
            p.Add("aboutID1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("aboutus_P.Deleteaboutus", p, commandType: CommandType.StoredProcedure);
        }


        public Aboutu GetaboutusById(int id)
        {
            var p = new DynamicParameters();
            p.Add("aboutID1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Aboutu> result = _dbContext.Connection.Query<Aboutu>("aboutus_P.GetaboutusById",p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }
    }
}
