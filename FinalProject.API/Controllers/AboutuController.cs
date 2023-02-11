using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutuController : ControllerBase
    {
        private readonly IAboutuService _aboutuService;
        public AboutuController(IAboutuService aboutuService)
        {
            _aboutuService = aboutuService;
        }

        [HttpGet]
        [Route("GetAllaboutus")]
        public List<Aboutu> GetAllaboutus()
        {
            return _aboutuService.GetAllaboutus();
        }


        [HttpPost]
        [Route("CreateAbout")]
        public void CreateAbout(Aboutu aboutu)
        {
            _aboutuService.CreateAbout(aboutu);
        }

        [HttpPut]
        [Route("Updateaboutus")]
        public void Updateaboutus(Aboutu aboutu)
        {
            _aboutuService.Updateaboutus(aboutu);
        }

        [HttpDelete]
        [Route("Deleteaboutus/{id}")]
        public void Deleteaboutus(int id)
        {
            _aboutuService.Deleteaboutus(id);
        }

        [HttpGet]
        [Route("GetaboutusById/{id}")]
        public Aboutu GetaboutusById(int id)
        {
            return _aboutuService.GetaboutusById(id);
        }
    }
}
