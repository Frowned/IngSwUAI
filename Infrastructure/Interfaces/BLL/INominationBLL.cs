using System.Collections.Generic;
using BE.DTO;
using BE.Entities;

namespace Infrastructure.Interfaces.BLL
{
    public interface INominationBLL
    {
        void NominateCollaborator(Nomination nomination);
        List<User> GetUsers();
        List<RecognitionCategory> GetRecognitionCategories();
        int GetUserNominationsCount(Guid userId, DateTime fromDate); 
        List<NominationCommentDTO> GetNominationComments(int nominationId);
        List<NominationDTO> GetNominationsByUser(Guid userId);
        void AddNominationHistory(NominationHistory nominationHistory);
        void AddNominationComment(NominationComment nominationComment);
        void CancelNomination(int nominationId);
        List<NominationHistoryDTO> GetNominationHistory(DateTime dateFrom, DateTime dateTo, Guid? collaboratorId, int? recognitionTypeId);
    }
}