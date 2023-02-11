using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository reportRepository;
        public ReportService(IReportRepository _ContactRepository)
        {
            this.reportRepository = _ContactRepository;
        }

        public Report GetGeneralReport()
        {
            return reportRepository.GetGeneralReport();
        }
    }
}
