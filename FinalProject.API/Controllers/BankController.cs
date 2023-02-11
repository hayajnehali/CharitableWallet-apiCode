using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;
        public BankController(IBankService bankService)
        {
            this.bankService = bankService;
        }
        [HttpGet("getAllBank")]
        public List<Bankaccount> GetAllBank()
        {
            return bankService.GetAllBank();
        }
        [HttpPost("createBank")]
        public void CreateBank(Bankaccount bankaccount)
        {
            bankService.CreateBank(bankaccount);
        }
        [HttpPut("UpdateBank")]
        public void UpdateBank([FromBody] Bankaccount bankaccount)
        {
            bankService.UpdateBank(bankaccount);
        }
        [HttpDelete]
        [Route("DeleteBank/{id}")]
        public void DeleteBank(int id)
        {
            bankService.DeleteBank(id);
        }
        [HttpGet]
        [Route("getBankbyid/{id}")]
        public Bankaccount GetBankPageById(int id)
        {
            return bankService.GetBankPageById(id);
        }

        [HttpPost]
        [Route("checkforcard")]
        public Bankaccount checkforcard([FromBody]Bankaccount card)
        {
            return bankService.checkforcard(card);
        }


    }
}
