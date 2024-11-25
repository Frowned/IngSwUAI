using System;
using System.Collections.Generic;
using Infrastructure.Interfaces.DAL;
using Infrastructure.Interfaces.BLL;
using BE.Entities;

namespace BLL
{
    public class NominationBLL : INominationBLL
    {
        private readonly INominationDAL _nominationDAL;

        public NominationBLL(INominationDAL nominationDAL)
        {
            _nominationDAL = nominationDAL;
        }

        public void NominateCollaborator(Nomination nomination)
        {
            nomination.CreatedAt = DateTime.Now;
            nomination.StatusId = 1; // Pendiente
            _nominationDAL.AddNomination(nomination);
        }

        public List<User> GetUsers()
        {
            return _nominationDAL.GetUsers();
        }

        public List<RecognitionCategory> GetRecognitionCategories()
        {
            return _nominationDAL.GetRecognitionCategories();
        }
    }
}