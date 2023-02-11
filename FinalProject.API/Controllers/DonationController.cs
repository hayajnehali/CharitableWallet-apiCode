using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonationService donationService;
        public DonationController(IDonationService donationService)
        {
            this.donationService = donationService;
        }
        [HttpGet]
        [Route("GetDonationCount")]
        public CountUser GetDonationCount()
        {
            return donationService.GetDonationCount();
        }

        [HttpGet]
        [Route("getAllDonation")]
        public List<DonationDto> getAllDonation()
        {
            return donationService.getAllDonation();
        }
        [HttpPost]
        [Route("CreateDonation")]
        public void CreateDonation([FromBody]Donation donation)
        {
            donationService.CreateDonation(donation);
        }
        [HttpPut]
        [Route("UpdateDonation")]
        public void UpdateDonation(Donation donation)
        {
            donationService.UpdateDonation(donation);
        }
        [HttpGet]

        [Route("GetDonationByuserId/{id}")]
        public List<DonationDto> GetDonationByuserId(int id)
        {
            return donationService.GetDonationByuserId(id);
        }
        [HttpDelete]
        [Route("DeleteDonation/{id}")]
        public void DeleteDonation(int id)
        {
            donationService.DeleteDonation(id);
        }

        [HttpGet]
        [Route("searchfordonations")]
        public List<DonationDto> searchfordonations([FromBody]searchdateDTO datess)
        {
            return donationService.searchfordonations(datess);
        }


    }
}
