using maskup.domain;
using maskup.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace maskup.repository
{
    public class AirCondictionRepo : IAirCondictionRepo
    {
        private AirDbModel db;
        public AirCondictionRepo()
        {
            db = new AirDbModel();
            //db.Database.CreateIfNotExists();            
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<AirCondiction> GetAll()
        {
            List<AirCondiction> airCondictionList = db.AirCondictions.ToList();
            return airCondictionList;
        }

        public AirCondiction GetById(Guid uid)
        {
            AirCondiction airCondiction = db.AirCondictions.Find(uid);
            return airCondiction;
        }


    }
}
