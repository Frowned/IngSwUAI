using BE.DTO;
using BE.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.DAL
{
    public interface ILanguageDAL
    {
        void Save(LanguageDTO pLanguage);
        int GetLastId();
        void Modify(Language pLanguage);
        void Delete(int pLanguageId);
        List<Translation> ListTranslations(int pLanguageId);
        List<Translation> ListDefaultTranslation();
        List<Label> GetLabels();
        Language? Get(string pLanguageName, bool withTranslation = false);
        LanguageDTO? GetById(int pLanguageId, bool withTranslation = false);
        List<LanguageDTO> ListLanguages(bool withTranslation = false);
        void AddLabel(Label label);
        void DeleteLabel(int labelId);
        bool LabelExists(string labelName);


    }
}
