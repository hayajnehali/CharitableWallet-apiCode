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
    public class RoleRepository : IRoleRepository
    {
        private readonly IDbContext dbContext;
        public RoleRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CREATERole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("roleName", role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = dbContext.Connection.Execute("Role_P.CREATERole", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("Role_P.DeleteRole", p, commandType: CommandType.StoredProcedure);
        }

        public List<Role> GetAllRoles()
        {
            IEnumerable<Role> users = dbContext.Connection.Query<Role>("Role_P.GetAllRoles", commandType: CommandType.StoredProcedure);
            return users.ToList();
        }

        public Role GetRoleById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Role> users = dbContext.Connection.Query<Role>("Role_P.GetRoleById", p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();
        }

        public void UPDATERole(int id, Role role)
        {

            var p = new DynamicParameters();

            p.Add("ID", role.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("roleNames", role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);
           
            var result = dbContext.Connection.Execute("Role_P.UPDATERole", p, commandType: CommandType.StoredProcedure);

        }
    }
}
