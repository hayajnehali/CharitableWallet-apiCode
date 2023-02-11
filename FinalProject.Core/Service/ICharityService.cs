using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface ICharityService
    {
        public List<Cahrity> GetAllcahrity();
        public void Createcahrity(Cahrity cahrity);
        public void Updatecahrity(Cahrity cahrity);
        public void UpdateCharityUserWallet(int id);
        public void DeleteCategory(int id);
        public Cahrity GetcahrityById(int id);
        public List<Cahrity> GetcahrityByCategory(int id);
        List<CharityDTO> getAllCharityDto(int id);
        public Cahrity GetCharityProfile(int id);
        void UpdateBalanceCharity(Cahrity cahrity);
        List<Cahrity> GetAllcahrityAccepted();



    }
}
