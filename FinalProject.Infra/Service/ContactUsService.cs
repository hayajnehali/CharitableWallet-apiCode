using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository ContactRepository;
        public ContactUsService(IContactUsRepository _ContactRepository)
        {
            this.ContactRepository = _ContactRepository;
        }

        public List<Contactu> GetAllcontactus()
        {
            return this.ContactRepository.GetAllcontactus();
        }

        public void CREATEcontactus(Contactu contactu)
        {
            ContactRepository.CREATEcontactus(contactu);
        }

        public void UPDATEcontactus(int id, Contactu contactu)
        {
            ContactRepository.UPDATEcontactus(id, contactu);
        }

        public Contactu GetcontactusById(int id)
        {
            return this.ContactRepository.GetcontactusById(id);
        }

        public void Deletecontactus(int id)
        {
            ContactRepository.Deletecontactus(id);
        }
    }
}
