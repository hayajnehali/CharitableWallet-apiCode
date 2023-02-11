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
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDbContext dbContext;
        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Contactu> GetAllcontactus()
        {
            IEnumerable<Contactu> users = dbContext.Connection.Query<Contactu>("contactus_p.GetAllcontactus", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public void CREATEcontactus(Contactu contactu)
        {
            var p = new DynamicParameters();
            p.Add("email1", contactu.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("subject1", contactu.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("msg1", contactu.Msg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phoneNumber1", contactu.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("contactus_p.CREATEcontactus", p, commandType: CommandType.StoredProcedure);

        }

        public void UPDATEcontactus(int id, Contactu contactu)
        {
            var p = new DynamicParameters();
            
            p.Add("ID", contactu.Contactid, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email1", contactu.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("subject1", contactu.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("msg1", contactu.Msg, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phoneNumber1", contactu.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("contactus_p.UPDATEcontactus", p, commandType: CommandType.StoredProcedure);
        }

        public Contactu GetcontactusById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Contactu> users = dbContext.Connection.Query<Contactu>("contactus_p.GetcontactusById", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }


        public void Deletecontactus(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("contactus_p.Deletecontactus", p, commandType: CommandType.StoredProcedure);
        }

    }
}
