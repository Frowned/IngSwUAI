using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Observer
{
    public interface ILanguageObserver
    {
        void Update(Language language);
    }
}
