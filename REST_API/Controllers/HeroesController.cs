using REST_API.Models;
using REST_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroRepository _heroRepository;

        public HeroesController(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        // GET: api/<Heroes>
        [HttpGet]
        [Route("/GetAllHeroes")]
        public List<HeroModel> GetAllHeroes()
        { 
            return _heroRepository.GetListOfHeroes();
        }

        // GET api/<Heroes>/5
        [HttpGet("/GetHeroById={id}")]
        public HeroModel GetHeroById(int id)
        {            
           return _heroRepository.GetHeroById(id);
        }

        //Add hero.
        //POST api/<Heroes>
        [HttpPost]
        [Route("/AddHero")]
        public void AddHero([FromBody] HeroModel heroModel)
        {
            
        }

        /// <summary>
        /// Update Hero by id;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<Heroes>/5
        [HttpPut("/UpdateHeroById={id}")]
        public void UpdateHeroById(int id, [FromBody] HeroModel heroModel)
        {
           
        }

        // DELETE api/<Heroes>/5
        [HttpDelete("/DeleteHeroById={id}")]
        public void DeleteHeroById(int id)
        {
           
        }
    }
}
