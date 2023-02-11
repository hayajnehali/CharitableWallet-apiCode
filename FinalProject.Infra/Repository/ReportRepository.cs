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
    public class ReportRepository: IReportRepository
    {
        private readonly IDbContext _dbContext;
        public ReportRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Report GetGeneralReport()
        {
            IEnumerable<Report> users = _dbContext.Connection.Query<Report>("report_p.GetGeneralReport", commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }



    }
}
