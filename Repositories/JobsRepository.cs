using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
    public class JobsRepository
    {

        private readonly IDbConnection _db;

        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Job> GetAll()
        {
            string sql = "SELECT * FROM jobs";
            return _db.Query<Job>(sql).ToList();
        }

        public Job Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            ()
            Values
            ();
            SELECT LAST_INSERT_ID()";

            newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
            return newJob;
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