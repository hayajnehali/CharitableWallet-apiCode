using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class AboutuService : IAboutuService
    {
        private readonly IAboutusRepository _aboutusRepository;

        public AboutuService(IAboutusRepository aboutusRepository)
        {
            _aboutusRepository = aboutusRepository;
        }

        public List<Aboutu> GetAllaboutus()
        {
            return _aboutusRepository.GetAllaboutus();
        }

        public void CreateAbout(Aboutu aboutu)
        {
            _aboutusRepository.CreateAbout(aboutu);
        }
        public void Updateaboutus(Aboutu aboutu)
        {
            _aboutusRepository.Updateaboutus(aboutu);
        }
        public void Deleteaboutus(int id)
        {
            _aboutusRepository.Deleteaboutus(id);
        }


        public Aboutu GetaboutusById(int id)
        {
            return _aboutusRepository.GetaboutusById(id);
        }
    }
}
