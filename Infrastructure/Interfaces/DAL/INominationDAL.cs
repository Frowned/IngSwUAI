using System;
using System.Collections.Generic;
using BE.Entities;

namespace Infrastructure.Interfaces.DAL
{
    public interface INominationDAL
    {
        void AddNomination(Nomination nomination);
        List<User> GetUsers();
        List<RecognitionCategory> GetRecognitionCategories();
    }
}