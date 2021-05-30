using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
    public class ContratorsService
    {

        private readonly ContractorsRepository _repo;

        public ContratorsService(ContractorsRepository repo)
        {
            _repo = repo;
        }

        internal List<Contractor> GetAll()
        {
            return _repo.GetAll();
        }

        internal Contractor Create(Contractor newContractor)
        {
            Contractor contractor = _repo.Create(newContractor);
            return contractor;
        }
    }
}