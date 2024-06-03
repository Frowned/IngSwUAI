using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entities
{
    public class Role : RoleComponent
    {
        public Role(string name, string type, string label) : base(name, type, label)
        {
            Children = new List<RoleComponent>();
        }

        public Role() : base()
        {
        }
    }
}
