using System;
using HomeWork.Data.Data;
using HomeWork.Data.Model;

namespace HomeWork.Data
{
    class Program
    {
        delegate IRepository<TEntity> RepositoryHandler<TEntity>() where TEntity : IEntity;
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };
            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            //RepositoryHandler<User> handlerUser = () => new EntityRepository<User>();
            //var userRepository = handlerUser().Add(user);
            //var userRepository = GetRepository<User>();
            //userRepository.Add(user);

            //RepositoryHandler<Phone> handlerPhone = () => new EntityRepository<Phone>();
            //handlerPhone().Add(phone);
            var contactRepository = GetRepository<Contact>();
            contactRepository.Add(phone);

            ////  Console.WriteLine(handlerPhone().GetById(1));

            Console.WriteLine(contactRepository.GetById(1));
            Console.ReadLine();
        }

        private static IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            return new EntityRepository<TEntity>();
        }
    }
}
