using BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Observer
{
    public abstract class Subject
    {
        private static List<ILanguageObserver> _observers = new List<ILanguageObserver>();

        public static void AddObserver(ILanguageObserver observer)
        {
            _observers.Add(observer);
        }


        public static void RemoveObserver(ILanguageObserver observer)
        {
            _observers.Remove(observer);
        }

        public static void Notify(Language language)
        {
            foreach (var observer in _observers)
                observer.Update(language);
        }

    }
}
