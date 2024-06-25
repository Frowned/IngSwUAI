using BE.DTO;
using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.BLL
{
    public interface ILanguageBLL
    {
        void Save(LanguageDTO pLanguage);
        void Delete(int pLanguageId);
        void Modify(Language pLanguage);
        Language Get(string pLanguageName, bool withTranslation = false);
        List<LanguageDTO> GetAllLanguages(bool withTranslation = false);
        List<Translation> GetAllTranslations(int pLanguageId);
        List<Label> GetLabels();
        void AddLabel(Label label);
        void DeleteLabel(int labelId);
        bool LabelExists(string labelName);

    }
}
