using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IContactUsService
    {
        List<Contactu> GetAllcontactus();
        void CREATEcontactus(Contactu contactu);
        void UPDATEcontactus(int id, Contactu contactu);
        Contactu GetcontactusById(int id);
        void Deletecontactus(int id);
    }
}
