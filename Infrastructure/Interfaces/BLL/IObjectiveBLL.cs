using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.DTO;

namespace Infrastructure.Interfaces.BLL
{
    public interface IObjectiveBLL
    {
        List<ObjectiveHistoryDTO> GetObjectiveHistory(DateTime dateFrom, DateTime dateTo, Guid? collaboratorId);
    }
}
