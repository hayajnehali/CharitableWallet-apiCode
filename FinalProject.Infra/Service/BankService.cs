using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class BankService :IBankService
    {
        private readonly IBankRepository bank;
        public BankService(IBankRepository bank)
        {
            this.bank = bank;
        }
        public List<Bankaccount> GetAllBank()
        {
            return bank.GetAllBank();
        }
        public void CreateBank(Bankaccount bankaccount)
        {
            bank.CreateBank(bankaccount);
        }
        public void UpdateBank(Bankaccount bankaccount)
        {
            bank.UpdateBank(bankaccount);
        }
        public void DeleteBank(int id)
        {
            bank.DeleteBank(id);
        }
        public Bankaccount GetBankPageById(int id)
        {
            return bank.GetBankPageById(id);
        }

        public Bankaccount checkforcard(Bankaccount card)
        {
            return bank.checkforcard(card);
        }




    }
}
