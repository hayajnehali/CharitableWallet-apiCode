using FinalProject.Core.Data;
using FinalProject.Core.Service;
using FinalProject.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("GetAllUsers")]

        public List<User> GetAllUsers()
        {
            return userService.GetAllUsers();
        }
        [HttpGet("GetbeneficharyCount")]
        public Countbenefichary GetbeneficharyCount()
        {
            return userService.GetbeneficharyCount();
        }
        [HttpPost("CheckAvailable")]
        public User userCheckAvailable(User user)
        {
            return userService.userCheckAvailable(user);
        }

        [HttpGet("getCountusers")]
        public allusercount getCountusers()
        {
            return userService.getCountusers();
        }

        [HttpPost]
        [Route("CreateUser")] 
        public void CreateUser([FromBody]User user)
        {
            userService.CreateUser(user);
        }
        [HttpGet("getallusersinnerrole")]
        public List<userRoleDto> getallusersinnerrole()
        {
            return userService.getallusersinnerrole();
        }

        [Route("UpdateUser")]
        [HttpPut]
        public void UpdateUser(User user)
        {
            userService.UpdateUser(user);
        }
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public void DeleteUser(int id)
        {
            userService.DeleteUser(id);
        }
        [HttpGet]
        [Route("GetUserById/{id}")]
        public User UserGetUserById(int id)
        {
            return userService.UserGetUserById(id);
        }

        [Route("UploadImages")]
        [HttpPost]
        public User UploadImage()
        {
            var file = Request.Form.Files[0];
            var filename = Guid.NewGuid().ToString() + "_"+file.FileName;
 
            var fullpath = Path.Combine("C:\\Users\\user\\Desktop\\tahaluf\\finalproject\\====f-p-13-1\\Charity-Platform-team\\src\\assets\\img", filename);
 
            using(var stream =new FileStream(fullpath , FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Imagepath= filename;
            return item;
        }

    }
}
