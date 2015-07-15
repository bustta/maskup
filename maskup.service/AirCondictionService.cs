using maskup.service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maskup.domain;
using maskup.repository;

namespace maskup.service
{
    public class AirCondictionService : IAirCondictionService
    {
        private AirCondictionRepo repo;
        public AirCondictionService()
        {
            repo = new AirCondictionRepo();
        }
        public void Dispose()
        {
            repo.Dispose();
        }

        public List<AirCondiction> GetLatestAndSort()
        {
            // TODO
            return repo.GetAll();
        }
    }
}
