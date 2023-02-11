using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
        public void CreateUser(User user)
        {
             userRepository.CreateUser(user);
        }
        public User userCheckAvailable(User user)
        {
            return userRepository.userCheckAvailable(user);
        }

        public void UpdateUser( User user)
        {
            userRepository.UpdateUser(user);
        }
        public User UserGetUserById(int id)
        {
            return userRepository.UserGetUserById(id);
        }
        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
        }

        public Countbenefichary GetbeneficharyCount()
        {
            return userRepository.GetbeneficharyCount();
        }
        public allusercount getCountusers()
        {
            return userRepository.getCountusers();
        }
        public List<userRoleDto> getallusersinnerrole()
        {
            return userRepository.getallusersinnerrole();
        }


    }
}
