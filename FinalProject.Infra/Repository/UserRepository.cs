using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FinalProject.Infra.Common;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;

namespace FinalProject.Infra.Repository
{
    public class UserRepository :IUserRepository
    {
        private readonly IDbContext dbContext;
        public UserRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<User> GetAllUsers()
        {
            IEnumerable<User> users = dbContext.Connection.Query<User>("User_P.GetAllUsers",commandType: CommandType.StoredProcedure);
            return users.ToList();
        }
        public Countbenefichary GetbeneficharyCount()
        {
            IEnumerable<Countbenefichary> donation = dbContext.Connection.Query<Countbenefichary>("User_P.getCountbeneficary", commandType: CommandType.StoredProcedure);
            return donation.SingleOrDefault();
        }
        public allusercount getCountusers()
        {
            IEnumerable<allusercount> donation = dbContext.Connection.Query<allusercount>("User_P.getCountusers", commandType: CommandType.StoredProcedure);
            return donation.SingleOrDefault();
        }
        public List<userRoleDto> getallusersinnerrole()
        {
            IEnumerable<userRoleDto> users = dbContext.Connection.Query<userRoleDto>("User_P.getallusersinnerrole", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public User userCheckAvailable(User user)
        {
            var p = new DynamicParameters();
            p.Add("emailC", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("usernameC", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phonenumberC", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<User> users = dbContext.Connection.Query<User>("User_P.userCheckAvailable", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();

        }


        public void CreateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("firstname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lastname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("gender", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("accepts", user.Isaccepted, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("roleid", user.RoleidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("Neptune-Shoop@outlook.com", "feras123");
            smtp.SendMailAsync("Neptune-Shoop@outlook.com", user.Email, "BENEVOLENT HAND", "Welcome to the Benevolent Hand family. Our motto is a giving hand");
            var result = dbContext.Connection.Execute("User_P.CreateUser", p, commandType: CommandType.StoredProcedure);
        }
        public void UpdateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("id", user.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("fname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("lname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pword", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("eml", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("gen", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("accepts", user.Isaccepted, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rolee", user.RoleidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("usname", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("requestMoney1", user.requestMoney, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("User_P.UpdateUser", p, commandType: CommandType.StoredProcedure);
        }
        public User UserGetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<User> users = dbContext.Connection.Query<User>("User_P.getuserbyid",p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();

        }
        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("User_P.DeleteUser", p, commandType: CommandType.StoredProcedure);
        }


    }
}
