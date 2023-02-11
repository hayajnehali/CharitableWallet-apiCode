using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IBankService
    {
        List<Bankaccount> GetAllBank();
        void CreateBank(Bankaccount bankaccount);
        void UpdateBank(Bankaccount bankaccount);
        void DeleteBank(int id);
        Bankaccount GetBankPageById(int id);

        public Bankaccount checkforcard(Bankaccount card);

    }
}
