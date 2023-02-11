using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface ICharityRepository
    {
        List<Cahrity> GetAllcahrity();
         void Createcahrity(Cahrity cahrity);
         void Updatecahrity(Cahrity cahrity);
        public void DeleteCategory(int id);
        public void UpdateCharityUserWallet(int id);
        public Cahrity GetcahrityById(int id);
        List<Cahrity> GetcahrityByCategory(int id);
        List<CharityDTO> getAllCharityDto(int id);
        public Cahrity GetCharityProfile(int id);
        void UpdateBalanceCharity(Cahrity cahrity);
        public List<Cahrity> GetAllcahrityAccepted();

    }
}
