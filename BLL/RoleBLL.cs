using BE.Entities;
using DAL;
using Infrastructure.Interfaces.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBLL : RoleComponentBLL, IRoleBLL
    {
        internal Role? _role = null;
        internal RoleDAL _roleDAL;

        public RoleBLL(Role role, RoleDAL roleDAL)
        {
            _role = role;
            _roleDAL = roleDAL;
        }

        public override void Add(RoleComponent component)
        {
            _roleDAL.Save((Role)component);
        }

        public void Delete(Role role)
        {
            _roleDAL.Delete(role);
        }

        public RoleComponent? Get(int roleId)
        {
            return _roleDAL.Get(roleId);
        }

        public RoleComponent? GetByLabel(string label)
        {
            return _roleDAL.GetByLabel(label);
        }

        public override IList<RoleComponent> GetChilds()
        {
            return _role!.Children;
        }

        public List<RoleComponent> GetChilds(int roleId)
        {
            return _roleDAL.GetChilds(roleId);
        }

        public int GetLastId()
        {
            return _roleDAL.GetLastId();
        }

        public List<RoleComponent> List(bool withChilds = true)
        {
            return _roleDAL.List(withChilds);
        }

        public List<RoleComponent> ListSimple()
        {
            return _roleDAL!.ListSimple();
        }

        public void Modify(Role role)
        {
            _roleDAL?.Modify(role);
        }
    }
}
