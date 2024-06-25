using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.DAL
{
    public interface IRoleDAL
    {
        void Save(Role role);
        int GetLastId();
        void Modify(Role role);
        void Delete(Role role);
        RoleComponent? Get(int roleId);
        RoleComponent? GetByLabel(string label);
        List<RoleComponent> GetChilds(int roleId);
        List<RoleComponent> List(bool withChilds = true);
        List<RoleComponent> ListSimple();

    }
}
