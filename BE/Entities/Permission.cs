using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entities
{
    public class Permission : RoleComponent
    {
        public Permission(string name, string type, string label) : base(name, type, label)
        {
        }

        public Permission() : base()
        {
        }
    }
}
