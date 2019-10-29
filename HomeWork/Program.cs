using System;
using HomeWork.Data.Data;
using HomeWork.Data.Model;

namespace HomeWork.Data
{
    class Program
    {
        delegate IRepository<TEntity> RepositoryFactory<TEntity>() where TEntity : IEntity;
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };
            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            RepositoryOperation(GetRepository<User>, r => r.Add(user));

            RepositoryOperation(GetRepository<Contact>, r =>
            {
                r.Add(phone);
                Console.WriteLine(r.GetById(1));
            });

            Console.ReadLine();
        }

        private static void RepositoryOperation<T>(RepositoryFactory<T> factory, Action<IRepository<T>> operation)
            where T : IEntity
        {
            operation(factory());
        }

        private static IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            return new EntityRepository<TEntity>();
        }
    }
}
