using Api.Mongo.Data.Collections;
using Api.Mongo.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mongo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class InfectedController : Controller
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infected> _infectedCollection;

        public InfectedController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectedCollection = _mongoDB.DB.GetCollection<Infected>(typeof(Infected).Name.ToLower());
        }

        [HttpPost]
        public IActionResult AddInfected([FromBody] InfectedDto infectedDto)
        {
            var infected = new Infected(
                infectedDto.DateTime,
                infectedDto.Gender,
                infectedDto.longitude,
                infectedDto.latitude);

            _infectedCollection.InsertOne(infected);
            return Ok("Infectado inserido com sucesso!");
        }

        [HttpGet]
        public IActionResult GetInfecteds()
        {
            var infectedList = _infectedCollection.Find(Builders<Infected>.Filter.Empty).ToList();

            return Ok(infectedList);
        }


        [HttpPut]
        public IActionResult UpdateInfected([FromBody] InfectedDto infectedDto)
        {
            
            _infectedCollection.UpdateOne(Builders<Infected>.Filter.Where(e => e.DateTime == infectedDto.DateTime), Builders<Infected>.Update.Set("Gender", infectedDto.Gender));
            //var infectedList = _infectedCollection.Find(Builders<Infected>.Filter.Empty).ToList();

            return Ok("Atualizado com sucesso!!");
        }

        [HttpDelete("{dateTime}")]
        public IActionResult DeleteInfected(DateTime dateTime)
        {
            
            _infectedCollection.DeleteOne(Builders<Infected>.Filter.Where(e => e.DateTime == dateTime));
            //var infectedList = _infectedCollection.Find(Builders<Infected>.Filter.Empty).ToList();

            return Ok("Atualizado com sucesso!!");
        }
    }
}
