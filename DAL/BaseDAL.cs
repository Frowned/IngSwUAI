namespace DAL
{
    public abstract class BaseDAL<T>
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
            return context.Where(i => i.Id.Equals(id)).FirstOrDefault();
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
