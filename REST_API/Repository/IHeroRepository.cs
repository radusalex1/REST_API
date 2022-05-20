using REST_API.Models;
using System.Collections.Generic;

namespace REST_API.Repositories
{
    /// <summary>
    /// First version
    /// </summary>
    public interface IHeroRepository
    {
        /// <summary>
        /// Reads the Json file and return the list of all heroes.
        /// </summary>
        /// <returns></returns>
        public List<HeroModel> GetListOfHeroes();

        /// <summary>
        /// Get hero by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HeroModel GetHeroById(int id);

        /// <summary>
        /// Adds a hero.
        /// </summary>
        /// <param name="hero"></param>
        public void AddHero(HeroModel hero);

        /// <summary>
        /// Deletes a hero.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveHero(int id);

       
    }
}
