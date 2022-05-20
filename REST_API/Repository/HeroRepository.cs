using Microsoft.EntityFrameworkCore;
using REST_API.Data;
using REST_API.Models;
using System.Collections.Generic;
using System.Linq;
using RefactorThis.GraphDiff;


namespace REST_API.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        private readonly HeroContext heroContext;

        public HeroRepository(HeroContext heroContext)
        {
            this.heroContext = heroContext;
        }

        public void AddHero(HeroModel hero)
        {
            //using (var context = new HeroContext())
            //{
            //    context.
            //}
        }

        public HeroModel GetHeroById(int id)
        {
            var result = heroContext.HeroModel
                .Include(hero => hero.PowerStats)
                .Include(hero => hero.Appearance)                   
                .Include(hero => hero.Appearance)
                    .ThenInclude(a => a.Weight)
                .Include(hero => hero.Appearance)
                    .ThenInclude(a => a.Height)
                .Include(hero => hero.Biography)
                    .ThenInclude(b => b.Aliases)
                .Include(hero => hero.Biography)
                .Include(hero => hero.Work)
                .Include(hero => hero.ConnectionsModel)
                .Include(hero => hero.Images)
                .FirstOrDefault(h => h.Id == id);

            return result;
        }

        public List<HeroModel> GetListOfHeroes()
        {
            List<HeroModel> heroes = new List<HeroModel>();

            heroes = heroContext.HeroModel
                .Include(h => h.Appearance)
                .Include(h => h.Biography)
                .Include(h => h.ConnectionsModel)
                .Include(h => h.Images)
                .Include(h => h.PowerStats)
                .Include(h => h.Work).ToList();

            return heroes;
        }

        public void RemoveHero(int id)
        {
            throw new System.NotImplementedException();
        }


        public void UpdateHero(HeroModel hero)
        {
            //using (var context = new HeroContext())
            //{
            //    // Update the company and state that the company 'owns' the collection Contacts.
            //    HeroModel heroModel = context.UpdateGraph<HeroModel>(hero, map => map.OwnedCollection(p => p.Contacts)
            //    );

            //    context.SaveChanges();
            //}

            // heroContext.UpdateGraph<HeroModel>(hero, map => map.OwnedCollection(p => p.test));

        }
    }
}
