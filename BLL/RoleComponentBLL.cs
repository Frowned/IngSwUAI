using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class RoleComponentBLL
    {
        public abstract IList<RoleComponent> GetChilds();
        public abstract void Add(RoleComponent component);
    }
}
