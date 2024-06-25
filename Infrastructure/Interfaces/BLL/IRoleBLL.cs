using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.BLL
{
    public interface IRoleBLL
    {
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
