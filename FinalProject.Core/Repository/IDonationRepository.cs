using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface IDonationRepository
    {
        public List<DonationDto> getAllDonation();
        public void CreateDonation(Donation donation);
        public void UpdateDonation(Donation donation);
        public List<DonationDto> GetDonationByuserId(int id);
        public void DeleteDonation(int id);
        public CountUser GetDonationCount();

        public List<DonationDto> searchfordonations(searchdateDTO datess);

    }
}
