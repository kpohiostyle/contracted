using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
    public class JobsService
    {

        private readonly JobsRepository _jobsRepository;

        public JobsService(JobsRepository jobsRepository)
        {
            _jobsRepository = jobsRepository;
        }

        internal List<Job> GetAll()
        {
            return _jobsRepository.GetAll();
        }

        internal Job Create(Job newJob)
        {
            throw new NotImplementedException();
        }
    }
}