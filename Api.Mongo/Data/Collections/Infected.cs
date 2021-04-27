using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mongo.Data.Collections
{
    public class Infected
    {
        public Infected(DateTime dateTime, string gender, double longitude, double latitude)
        {
            DateTime = dateTime;
            Gender = gender;
            Location = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DateTime { get; set; }
        public string Gender { get; set; }
        public GeoJson2DGeographicCoordinates Location { get; set; }
    }
}
