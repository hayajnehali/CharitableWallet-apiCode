using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IAboutuService
    {
        public List<Aboutu> GetAllaboutus();
        public void CreateAbout(Aboutu aboutu);
        public void Updateaboutus(Aboutu aboutu);
        public void Deleteaboutus(int id);
        public Aboutu GetaboutusById(int id);
    }
}
