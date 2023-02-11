using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService _roleService)
        {
            this.roleService = _roleService;
        }

        [HttpGet("GetAllRoles")]
        public List<Role> GetAllroles()
        {
            return this.roleService.GetAllRoles();
        }
        [HttpPost("CREATERole")]
        public void CREATEroles(Role role)
        {
            roleService.CREATERole(role);
        }
        [HttpPut("UPDATERole/{id}")]
        public void UPDATEroles(int id, Role role)
        {
            roleService.UPDATERole(id, role);
        }
        [HttpGet("GetRoleById/{id}")]
        public Role GetRoleById(int id)
        {
            return this.roleService.GetRoleById(id);
        }
        [HttpDelete("DeleteRole/{id}")]
        public void Deleteroles(int id)
        {
            roleService.DeleteRole(id);
        }
    }
}
