using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void CreateUser(User user);
        public void UpdateUser(User user);
        User UserGetUserById(int id);
        public void DeleteUser(int id);
        public Countbenefichary GetbeneficharyCount();
        public allusercount getCountusers();
        List<userRoleDto> getallusersinnerrole();

        User userCheckAvailable(User user);
    }
}
