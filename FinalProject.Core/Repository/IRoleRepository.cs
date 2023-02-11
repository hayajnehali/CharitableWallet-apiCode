using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface IRoleRepository
    {
        List<Role> GetAllRoles();
        void CREATERole(Role role);
        void UPDATERole(int id, Role role);
        Role GetRoleById(int id);
        void DeleteRole(int id);
    }
}
