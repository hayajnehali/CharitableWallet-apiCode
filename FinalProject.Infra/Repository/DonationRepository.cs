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
    public class DonationRepository :IDonationRepository
    {
        private readonly IDbContext _dbContext;
        public DonationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<DonationDto> getAllDonation()
        {
            IEnumerable<DonationDto> donation = _dbContext.Connection.Query<DonationDto>("Donation_p.getAllDonation", commandType: CommandType.StoredProcedure);
            return donation.ToList();
        }
        public List<DonationDto> GetDonationByuserId(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<DonationDto> donation = _dbContext.Connection.Query<DonationDto>("Donation_p.getDonationByUserid",p, commandType: CommandType.StoredProcedure);
            return donation.ToList();

        }
        public CountUser GetDonationCount()
        {
            IEnumerable<CountUser> donation = _dbContext.Connection.Query<CountUser>("Donation_p.selectCountDonation", commandType: CommandType.StoredProcedure);

            return donation.SingleOrDefault();
        }

        public void CreateDonation(Donation donation)
        {
            var p = new DynamicParameters();
            p.Add("amountt", donation.Amount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("charityfkk", donation.Charityfk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userfkk", donation.Userfk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DateDon", donation.Datedonation, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("Donation_p.createDonation", p, commandType: CommandType.StoredProcedure);

        }
        public void UpdateDonation(Donation donation)
        {
            var p = new DynamicParameters();
            p.Add("amountt", donation.Amount, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("charityfkk", donation.Charityfk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("userfkk", donation.Userfk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DateDon", donation.Datedonation, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("id", donation.Donationid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("Donation_p.updateDonation", p, commandType: CommandType.StoredProcedure);



        }
        public void DeleteDonation(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("Donation_p.deleteDonation", p, commandType: CommandType.StoredProcedure);

        }

        public List<DonationDto> searchfordonations(searchdateDTO datess)
        {
            var p = new DynamicParameters();
            p.Add("DateDon1", datess.date1, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("DateDon2", datess.date2, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<DonationDto> donation = _dbContext.Connection.Query<DonationDto>("Donation_p.searchfordonations",p, commandType: CommandType.StoredProcedure);
            return donation.ToList();


        }




    }
}
