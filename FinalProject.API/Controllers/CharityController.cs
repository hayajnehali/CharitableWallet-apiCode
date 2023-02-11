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
    public class CharityController : ControllerBase
    {
        private readonly ICharityService _charityService;
        public CharityController(ICharityService charityService)
        {
            _charityService = charityService;
        }

        [HttpGet]
        [Route("GetAllcahrity")]
        public List<Cahrity> GetAllcahrity()
        {
            return _charityService.GetAllcahrity();
        }


        [HttpPost]
        [Route("Createcahrity")]
        public void Createcahrity(Cahrity cahrity)
        {
            _charityService.Createcahrity(cahrity);
        }

        [HttpPut]
        [Route("Updatecahrity")]
        public void Updatecahrity(Cahrity cahrity)
        {
            _charityService.Updatecahrity(cahrity);
        }

        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            _charityService.DeleteCategory(id);
        }

        [HttpGet]
        [Route("GetcahrityById/{id}")]
        public Cahrity GetcahrityById(int id)
        {
            return _charityService.GetcahrityById(id);
        }
        [HttpGet]
        [Route("GetcahrityByCategory/{id}")]
        public List<Cahrity> GetcahrityByCategory(int id)
        {
            return _charityService.GetcahrityByCategory(id);
        }


        [HttpGet]
        [Route("getAllCharityDto/{id}")]
        public List<CharityDTO> getAllCharityDto(int id)
        {
            return _charityService.getAllCharityDto(id);
        }



        [HttpGet]
        [Route("getCharityProfile/{id}")]
        public Cahrity GetCharityProfile(int id)
        {
            return _charityService.GetCharityProfile(id);
        }
        [HttpPut]
        [Route("UpdateBalanceCharity")]
        public void UpdateBalanceCharity([FromBody] Cahrity cahrity)
        {
            _charityService.UpdateBalanceCharity(cahrity);
        }
        [HttpGet]
        [Route("GetAllcahrityAccepted")]
        public List<Cahrity> GetAllcahrityAccepted()
        {
            return _charityService.GetAllcahrityAccepted();
        }
        [HttpGet]
        [Route("UpdateCharityUserWallet/{id}")]
        public void UpdateCharityUserWallet(int id)
        {
            _charityService.UpdateCharityUserWallet(id);
        }
        [Route("UploadDocs")]
        [HttpPost]
        public Cahrity UploadDocs()
        {
            var file = Request.Form.Files[0];
            var filename = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullpath = Path.Combine("C:\\Users\\user\\Desktop\\tahaluf\\finalproject\\====f-p-13-1\\Charity-Platform-team\\src\\assets\\Docs", filename);
            using (var stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Cahrity item = new Cahrity();
            item.DocidFk = filename;
            return item;
        }
    }
}
