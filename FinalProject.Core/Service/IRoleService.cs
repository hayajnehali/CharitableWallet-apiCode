using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();
        void CREATERole(Role role);
        void UPDATERole(int id, Role role);
        Role GetRoleById(int id);
        void DeleteRole(int id);
    }
}
