using Dapper;
using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Infra.Repository
{
    public class BankRepository :IBankRepository
    {
        private readonly IDbContext dbContext;
        public BankRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Bankaccount> GetAllBank()
        {
            IEnumerable<Bankaccount> result = dbContext.Connection.Query<Bankaccount>("BankAccount_p.getallAccount", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void CreateBank(Bankaccount bankaccount)
        {
            var p = new DynamicParameters();
            p.Add("BalanceP",bankaccount.Balance , dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("AccountNumP", bankaccount.Accountnum, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("expireddatee", bankaccount.EXPIREDDATE, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("fulln", bankaccount.FULLNAME, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("cvv", bankaccount.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("BankAccount_p.createAccount", p, commandType: CommandType.StoredProcedure);

        }
        public void UpdateBank(Bankaccount bankaccount)
        {
            var p = new DynamicParameters();
            p.Add("id", bankaccount.Accountid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BalanceP", bankaccount.Balance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("AccountNo", bankaccount.Accountnum, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cvvv", bankaccount.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("exDate", bankaccount.EXPIREDDATE, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("fname", bankaccount.FULLNAME, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.Execute("BankAccount_p.updateAccount", p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteBank(int id)
        {
            var p = new DynamicParameters();

            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("BankAccount_p.deleteAccount", p, commandType: CommandType.StoredProcedure);
        }


        public Bankaccount GetBankPageById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Bankaccount> result = dbContext.Connection.Query<Bankaccount>("BankAccount_p.getaccountbyid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Bankaccount checkforcard(Bankaccount card)
        {
            var p = new DynamicParameters();
            p.Add("AccountNo", card.Accountnum, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("exDate", card.EXPIREDDATE, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("cvvv", card.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("fname", card.FULLNAME, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Bankaccount> result = dbContext.Connection.Query<Bankaccount>("BankAccount_p.checkforcard", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();

        }
    }
}
