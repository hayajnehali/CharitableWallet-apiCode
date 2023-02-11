using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService(IRoleRepository _roleRepository)
        {
            this.roleRepository = _roleRepository;
        }

        public List<Role> GetAllRoles()
        {
            return roleRepository.GetAllRoles();
        }
        public void CREATERole(Role role)
        {
            roleRepository.CREATERole(role);
        }
        public void UPDATERole(int id, Role role)
        {
            roleRepository.UPDATERole(id, role);
        }
        public Role GetRoleById(int id)
        {
            return roleRepository.GetRoleById(id);
        }
        public void DeleteRole(int id)
        {
            roleRepository.DeleteRole(id);
        }

    }
}
