using Interfaces;
using System.Linq;

namespace DAL
{
    public abstract class BaseDAL<T> where T : IBaseEntity
    {
        protected IList<T> context;
        public BaseDAL()
        {
            context = new List<T>();
        }

        public void Delete(T entity)
        {
            this.context.Remove(entity);
        }

        public IList<T> GetAll()
        {
            return context;
        }

        public T GetById(Guid id)
        {
            return context.Where(i => i.Id.Equals(id)).FirstOrDefault() == null ? default! : context.Where(i => i.Id.Equals(id)).First();
        }

        public void Save(T entity)
        {
            if (context.Contains(entity))
            {
                //si no fuesen objetos, habria que invocar la forma de actualizar el dato en el entorno de persistencia
            }
            else
            {
                context.Add(entity);
            }

        }

    }
}
