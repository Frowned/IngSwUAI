using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class RoleComponent
    {
        public List<RoleComponent> Children { get; set; }

        public RoleComponent()
        {
            Children = new List<RoleComponent>();
        }

        public RoleComponent(string name, string type, string label)
        {
            this.Name = name;
            this.Label = label;
            this.Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
    }
}
