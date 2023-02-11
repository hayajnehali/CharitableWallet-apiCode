using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IHomeService
    {
        List<Homepage> GetAllHome();
        void CreateHome(Homepage homepage);
        void UpdateHome(Homepage homepage);
        void DeleteHome(int id);
        Homepage GetHomePageById(int id);
    }
}
