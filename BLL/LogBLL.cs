using BE.Entities;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Interfaces.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogBLL : ILogBLL
    {
        private ILogDAL _logDAL;
        public LogBLL(ILogDAL logDAL)
        {
            _logDAL = logDAL;
        }

        public void Save(Log log)
        {
            _logDAL.Save(log);
        }
    }
}
