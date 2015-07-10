using feeder.Binding;
using feeder.Util;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace feeder.Service
{
    public class AirCondictionService
    {
        private AirModel db;

        public AirCondictionService()
        {
            db = new AirModel();
        }

        public void InsertWithReflectionBinding(List<string> dataList)
        {
            foreach (string item in dataList)
            {
                JObject jobject = JObject.Parse(item);
                AirCondiction air = new DataMapping().ReflectionToAssignObject(jobject);
                db.AirCondiction.Add(air);
                db.SaveChanges();
            }
        }
    }
}