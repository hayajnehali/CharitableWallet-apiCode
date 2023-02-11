using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class HomeService :IHomeService
    {
        private readonly IHomeRepository homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }
        public List<Homepage> GetAllHome()
        {
            return homeRepository.GetAllHome();
        }
        public void CreateHome(Homepage homepage)
        {
            homeRepository.CreateHome(homepage);
        }
        public void UpdateHome(Homepage homepage)
        {
            homeRepository.UpdateHome(homepage);
        }
        public void DeleteHome(int id)
        {
            homeRepository.DeleteHome(id);
        }
        public Homepage GetHomePageById(int id)
        {
            return homeRepository.GetHomePageById(id);
        }



    }
}
