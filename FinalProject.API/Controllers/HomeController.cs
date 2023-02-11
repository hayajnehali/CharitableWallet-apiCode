using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }
        [HttpGet("getallhome")]
        public List<Homepage> GetAllHome()
        {
            return homeService.GetAllHome();
        }
        [HttpPost("CreateHome")]
        public void CreateHome(Homepage homepage)
        {
            homeService.CreateHome(homepage);
        }
        [HttpPut("updateHome")]
        public void UpdateHome(Homepage homepage)
        {
            homeService.UpdateHome(homepage);
        }
        [HttpDelete]
        [Route("deletehome/{id}")]
        public void DeleteHome(int id)
        {
            homeService.DeleteHome(id);
        }
        [HttpGet]
        [Route("GetHomebyId")]
        public Homepage GetHomePageById(int id)
        {
            return homeService.GetHomePageById(id);
        }


    }
}
