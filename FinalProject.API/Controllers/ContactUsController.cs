using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService _contactUsService)
        {
            this.contactUsService = _contactUsService;
        }

        [HttpGet("GetAllcontactus")]
        public List<Contactu> GetAllcontactus()
        {
            return this.contactUsService.GetAllcontactus();
        }
        [HttpPost("CREATEcontactus")]
        public void CREATEcontactus(Contactu contactu)
        {
            contactUsService.CREATEcontactus(contactu);
        }
        [HttpPut("UPDATEcontactus/{id}")]
        public void UPDATEcontactus(int id, Contactu contactu)
        {
            contactUsService.UPDATEcontactus(id, contactu);
        }
        [HttpGet("GetcontactusById/{id}")]
        public Contactu GetcontactusById(int id)
        {
            return this.contactUsService.GetcontactusById(id);
        }
        [HttpDelete("Deletecontactus/{id}")]
        public void Deletecontactus(int id)
        {
            contactUsService.Deletecontactus(id);
        }

    }
}
