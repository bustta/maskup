using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using maskup.domain;

namespace feeder.Util
{
    public class DataMapping
    {
        public AirCondiction ReflectionToAssignObject(JObject jsonObject)
        {
            AirCondiction airCondiction = new AirCondiction();
            PropertyInfo[] props = airCondiction.GetType().GetProperties();

            airCondiction.location = jsonObject["SiteKey"].Value<string>();
            airCondiction.locationCht = jsonObject["SiteName"].Value<string>();
            airCondiction.datetime = DateTime.Now;
            airCondiction.id = Guid.NewGuid();

            foreach (var item in jsonObject)
            {
                string key = item.Key;
                string value = item.Value.Value<string>();
                if (string.IsNullOrEmpty(value) || value.Trim() == "-") continue;

                foreach (PropertyInfo prop in props)
                {
                    if (String.Compare(key, prop.Name, true) != 0) continue;
                    try
                    {
                        prop.SetValue(airCondiction, Convert.ChangeType(value, prop.PropertyType));
                    }
                    catch (ArgumentException ex)
                    {
                        throw ex;
                    }
                    catch (InvalidCastException ex)
                    {
                        throw ex;
                    }
                }
            }
            return airCondiction;
        }
    }
}