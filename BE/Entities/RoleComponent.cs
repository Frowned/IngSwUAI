using BE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entities
{
    public abstract class RoleComponent : BaseEntity
    {
        public List<RoleComponent> Children { get; set; }

        public RoleComponent()
        {
            Children = new List<RoleComponent>();
        }

        public RoleComponent(string name, string type, string label)
        {
            Name = name;
            Label = label;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
    }
}
