using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mongo.Models
{
    public class InfectedDto
    {
        public DateTime DateTime { get; set; }
        public string Gender { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
    }
}
