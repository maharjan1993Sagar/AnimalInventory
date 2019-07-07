using AnimalInventory.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalInventory.Core.Interfaces;
using AnimalInventory.Core.Repositories;

namespace AnimalInventory.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private AnimalContext _repoContext;
        

        public UnitOfWork(AnimalContext repositoryContext)
        {
            _repoContext = repositoryContext;
           // users = new UserRepository(_repoContext);
        }


        //public IUserRepository Users
        //{
        //    get; private set;
        //}


        public void Dispose()
        {
            _repoContext.Dispose();
        }

    }
}