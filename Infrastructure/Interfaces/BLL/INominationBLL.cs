using System.Collections.Generic;
using BE.Entities;

namespace Infrastructure.Interfaces.BLL
{
    public interface INominationBLL
    {
        void NominateCollaborator(Nomination nomination);
        List<User> GetUsers();
        List<RecognitionCategory> GetRecognitionCategories();
    }
}