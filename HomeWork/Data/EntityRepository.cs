using System.Collections.Generic;
using System.Linq;
using HomeWork.Data.Model;

namespace HomeWork.Data.Data
{
    public class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private delegate TEntity FilterFromRepository(long id);

        private static TEntity FirstEntityCollectionById(long id)
        {
            return _storage.FirstOrDefault(x => x.Id == id);
        }

        private FilterFromRepository filterFromRepository = FirstEntityCollectionById;

        private static readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity contact)
        {
            _storage.Add(contact);
        }

        public void Remove(TEntity contact)
        {
            _storage.Remove(contact);
        }

        public TEntity GetById(long id)
        {
            return filterFromRepository(id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }


    }
}
