using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface IHomeRepository
    {
        List<Homepage> GetAllHome();
        void CreateHome(Homepage homepage);
        void UpdateHome(Homepage homepage);
        void DeleteHome(int id);
        Homepage GetHomePageById(int id);
    }
}
