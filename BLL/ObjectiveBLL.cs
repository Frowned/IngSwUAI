using BE.DTO;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Interfaces.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ObjectiveBLL : IObjectiveBLL
    {
        private readonly IObjectiveDAL _objectiveDAL;
        public ObjectiveBLL(IObjectiveDAL objectiveDAL)
        {
            _objectiveDAL = objectiveDAL;
        }

        public List<ObjectiveHistoryDTO> GetObjectiveHistory(DateTime dateFrom, DateTime dateTo, Guid? collaboratorId)
        {
            return _objectiveDAL.GetObjectiveHistory(dateFrom, dateTo, collaboratorId);
        }
    }
}
