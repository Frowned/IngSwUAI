using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.DAL
{
    public interface ILogDAL
    {
        void Save(Log log);
    }
}
