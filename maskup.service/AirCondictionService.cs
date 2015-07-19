using maskup.service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using maskup.domain;


namespace maskup.service
{
    public class AirCondictionService : IAirCondictionService
    {
        private AirServiceDbModel db;
        public AirCondictionService()
        {
            db = new AirServiceDbModel();
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<AirCondiction> GetAll()
        {
            var airCondictionList = db.AirCondictions.OrderByDescending(x => x.datetime).ToList();
            return airCondictionList;
        }

        public AirCondiction GetById(Guid uid)
        {
            var airCondiction = db.AirCondictions.Find(uid);
            return airCondiction;
        }

        public List<AirCondiction> GetLatestAndSort()
        {
            
            var anchor = db.AirCondictions.OrderByDescending(x => x.datetime).First();
            var result = db.AirCondictions
                .Where(x => (
                    x.datetime.Hour == anchor.datetime.Hour &&
                    x.datetime.Minute == anchor.datetime.Minute
                    ))
                .OrderBy(x => x.pm25)
                .ToList();

            // TODO: handle the ArgumentNullException and InvalidOperationException, but not important in fact          
            

            return result;
        }
    }
}
