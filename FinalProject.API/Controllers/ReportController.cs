using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        private readonly IReportService reportService;
        public ReportController(IReportService _reportService)
        {
            this.reportService = _reportService;
        }

        [HttpGet]
        [Route("GetGeneralReport")]
        public Report GetGeneralReport()
        {
            return reportService.GetGeneralReport();
        }
    }
}
