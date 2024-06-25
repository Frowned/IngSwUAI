using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissionBLL : RoleComponentBLL
    {
        public string GetLabel(Permission permission)
        {
            return permission.Label;
        }

        public override void Add(RoleComponent component)
        {
            throw new NotImplementedException();
        }

        public override IList<RoleComponent> GetChilds()
        {
            throw new NotImplementedException();
        }
    }
}
