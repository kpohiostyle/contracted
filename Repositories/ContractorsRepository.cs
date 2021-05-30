using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
    public class ContractorsRepository
    {

        private readonly IDbConnection _db;

        public ContractorsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal List<Contractor> GetAll()
        {
            string sql = "SELECT * FROM contractors";
            return _db.Query<Contractor>(sql).ToList();
        }

        internal Contractor Create(Contractor newContractor)
        {
            string sql = @"
            INSERT INTO contractors
            ()
            Values
            ();
            SELECT LAST_INSERT_ID()";

            newContractor.Id = _db.ExecuteScalar<int>(sql, newContractor);
            return newContractor;
        }

        public Job GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Job Update(Job data)
        {
            throw new System.NotImplementedException();
        }

    }
}