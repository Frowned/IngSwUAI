using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.BLL
{
    public interface ILogBLL
    {
        void Save(Log log);
    }
}
