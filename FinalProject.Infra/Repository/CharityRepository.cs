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
    public class CharityRepository : ICharityRepository
    {
        private readonly IDbContext _dbContext;
        public CharityRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<Cahrity> GetAllcahrity() { 

              IEnumerable<Cahrity> users = _dbContext.Connection.Query<Cahrity>("cahrity_P.getallcahrity", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }
        public List<Cahrity> GetAllcahrityAccepted()
        {
            IEnumerable<Cahrity> users = _dbContext.Connection.Query<Cahrity>("cahrity_P.getAllCharityAccepted", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public void Createcahrity(Cahrity cahrity)
        {

            var p = new DynamicParameters();
            p.Add("userid_fk1", cahrity.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CharityName1", cahrity.CHARITYNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("docid_fk1", cahrity.DocidFk, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagePath1", cahrity.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("goal1", cahrity.Goal, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("email1", cahrity.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("numDonation1", cahrity.Numdonation, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("balance1", cahrity.Balance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("isAccepted1", cahrity.Isaccepted, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("categoryID_fk1", cahrity.CategoryidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("state1", cahrity.State, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("cahrity_P.Createcahrity", p, commandType: CommandType.StoredProcedure);

        }


        public void Updatecahrity(Cahrity cahrity)
        {
            var p = new DynamicParameters();
            p.Add("charityID1", cahrity.Charityid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userid_fk1", cahrity.UseridFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("docid_fk1", cahrity.DocidFk, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("CharityName1", cahrity.CHARITYNAME, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagePath1", cahrity.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("goal1", cahrity.Goal, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("email1", cahrity.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("numDonation1", cahrity.Numdonation, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("balance1", cahrity.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("isAccepted1", cahrity.Isaccepted, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("categoryID_fk1", cahrity.CategoryidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("state1", cahrity.State, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result =  _dbContext.Connection.Execute("cahrity_P.Updatecahrity", p, commandType: CommandType.StoredProcedure);

        }



        public void DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("charityID1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           _dbContext.Connection.Execute("cahrity_P.Deletecahrity", p, commandType: CommandType.StoredProcedure);
       
        }

        public Cahrity GetcahrityById(int id)
        {
            var p = new DynamicParameters();
            p.Add("IcharityIDD1", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cahrity> result = _dbContext.Connection.Query<Cahrity>("cahrity_P.GetcahrityById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public List<Cahrity> GetcahrityByCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cahrity> result = _dbContext.Connection.Query<Cahrity>("cahrity_P.getCharityByCategory",p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<CharityDTO> getAllCharityDto(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CharityDTO> result = _dbContext.Connection.Query<CharityDTO>("cahrity_P.getCharityDTO", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public Cahrity GetCharityProfile(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Cahrity> result = _dbContext.Connection.Query<Cahrity>("cahrity_P.GetCharityProfile", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }
        public void UpdateBalanceCharity(Cahrity cahrity)
        {
            var p = new DynamicParameters();
            p.Add("id", cahrity.Charityid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("balance1", cahrity.Balance, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("cahrity_P.updateBalanceCharity", p, commandType: CommandType.StoredProcedure);

        }

        public void UpdateCharityUserWallet(int id)
        {
            var p = new DynamicParameters();
            p.Add("userid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("cahrity_P.UpdateCharityUserWallet", p, commandType: CommandType.StoredProcedure);

        }
    }
}
