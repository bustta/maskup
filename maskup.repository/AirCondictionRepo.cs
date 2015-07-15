using maskup.domain;
using System.Collections.Generic;
using System.Linq;

namespace maskup.repository
{
    public class AirCondictionRepo
    {
        private AirDbModel db;
        public AirCondictionRepo()
        {
            db = new AirDbModel();
            //db.Database.CreateIfNotExists();
            
        }

        public List<AirCondiction> Get()
        {
            List<AirCondiction> airCondictionList = db.AirCondictions.ToList();
            return airCondictionList;
        }

        public AirCondiction GetById(string uid)
        {
            AirCondiction airCondiction = db.AirCondictions.Find(uid);
            return airCondiction;
        }
    }
}
