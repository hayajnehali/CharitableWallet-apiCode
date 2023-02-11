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
    public class WalletRepository: IWalletRepository
    {
        private readonly IDbContext dbContext;
        public WalletRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /*PROCEDURE GetAllWallets;
PROCEDURE GetWalletById(id in number);

PROCEDURE CREATEWallets(balance in wallets.balance%TYPE, userID_fk in wallets.userID_fk%type, BankAccount_fk in wallets.BankAccount_fk%type);

PROCEDURE UPDATEWallets(ID IN NUMBER , balances IN
number, userID_fks IN number, BankAccount_fks in number);

PROCEDURE DeleteWallets(Id in number);*/
        public void CREATEWallets(Wallet wallet)
        {
            var p = new DynamicParameters();
            p.Add("balance", wallet.Balance, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("userID_fk", wallet.UseridFk, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BankAccount_fk", wallet.BankaccountFk, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Wallets_P.CREATEWallets", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteWallets(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Wallets_P.DeleteWallets", p, commandType: CommandType.StoredProcedure);
        }

        public List<Wallet> GetAllWallets()
        {
            IEnumerable<Wallet> users = dbContext.Connection.Query<Wallet>("Wallets_P.GetAllWallets", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public Wallet GetWalletById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Wallet> users = dbContext.Connection.Query<Wallet>("Wallets_P.GetWalletById", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }

        public Wallet GetWalletByUserId(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Wallet> users = dbContext.Connection.Query<Wallet>("Wallets_P.GetWalletByUserId", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }
        public Wallet getwalletforuser(int id)
        {
            var p = new DynamicParameters();
            p.Add("useridw", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Wallet> users = dbContext.Connection.Query<Wallet>("Wallets_P.getwalletforuser", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();

        }
        public Wallet getWalletandBankCheck(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Wallet> users = dbContext.Connection.Query<Wallet>("Wallets_P.getWalletandBankCheck", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }

        public void UPDATEWallets( Wallet wallet)
        {

            var p = new DynamicParameters();

            p.Add("ID", wallet.Walletid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("balances", wallet.Balance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userID_fks", wallet.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BankAccount_fks", wallet.BankaccountFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Wallets_P.UPDATEWallets", p, commandType: CommandType.StoredProcedure);
      

        }

        public void transfermoney(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Wallets_trasferMoney_P.transfermoney", p, commandType: CommandType.StoredProcedure);

        }
        public WalletDto getWalletAndBank(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<WalletDto> users = dbContext.Connection.Query<WalletDto>("Wallets_P.getWalletandBank", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }

 
    }
}
