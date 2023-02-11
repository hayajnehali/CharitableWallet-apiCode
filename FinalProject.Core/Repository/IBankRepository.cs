using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface IBankRepository
    {
        List<Bankaccount> GetAllBank();
        void CreateBank(Bankaccount bankaccount);
        void UpdateBank(Bankaccount bankaccount);
        void DeleteBank(int id);
        Bankaccount GetBankPageById(int id);

        Bankaccount checkforcard(Bankaccount card);
    }
}
