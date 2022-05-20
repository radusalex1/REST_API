using Newtonsoft.Json;
using REST_API.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace REST_API.Data
{
    public class DbInitializer
    {
        public static void Initialize(HeroContext heroContext)
        {

            heroContext.Database.EnsureCreated();

            if (heroContext.HeroModel.Any())
            {
                return;
            }

            List<HeroModelJSON> heroes = new List<HeroModelJSON>();

            using (var reader = new StreamReader(@"D:\Projects\API_TEST\REST_API\REST_API\superheroes - Copy.json"))
            {
                string jsonString = reader.ReadToEnd();

                heroes = JsonConvert.DeserializeObject<List<HeroModelJSON>>(jsonString);
            }

            


            foreach (HeroModelJSON hero in heroes)
            {
                ///---------------------PowerStats-----------------------------------------------------------
                PowerStatsModel powerStatsModel = new PowerStatsModel(
                                                                      hero.PowerStats.Intelligence,
                                                                      hero.PowerStats.Strength,
                                                                      hero.PowerStats.Speed,
                                                                      hero.PowerStats.Durability,
                                                                      hero.PowerStats.Power,
                                                                      hero.PowerStats.Combat);

                ///--------------------Appearance------------------------------------------------------------

                HeightModel heightModel = new HeightModel(hero.Appearance.Height[0],
                                                          hero.Appearance.Height[1]);

                WeightModel weightModel = new WeightModel(hero.Appearance.Weight[0],
                                                          hero.Appearance.Weight[1]);

                AppearanceModel appearance = new AppearanceModel(
                                                                 hero.Appearance.Gender,
                                                                 hero.Appearance.Race,
                                                                 heightModel,
                                                                 weightModel,
                                                                 hero.Appearance.EyeColor,
                                                                 hero.Appearance.HairColor);

                ///-------------------Biography-----------------------------------------------------

                List<AliasesModel> aliases = new List<AliasesModel>();

                foreach (var alias in hero.Biography.Aliases)
                {
                    AliasesModel aliasesModel = new AliasesModel(alias);
                    aliases.Add(aliasesModel);
                }

                BiographyModel biography = new BiographyModel(hero.Biography.FullName,
                                                              hero.Biography.AlterEgo,
                                                              aliases,
                                                              hero.Biography.PlaceOfBirth,
                                                              hero.Biography.FirstAppearance,
                                                              hero.Biography.Publisher,
                                                              hero.Biography.Alignment);

                ///------------------Work------------------------------------------------------------------
                WorkModel workModel = new WorkModel(hero.Work.Occupation,
                                                    hero.Work.Base);

                ///----------------Connections-------------------------------------------------------------
                ConnectionsModel connections = new ConnectionsModel(hero.ConnectionsModel.GroupAffiliation,
                                                                    hero.ConnectionsModel.Relatives);


                ///---------------Images--------------------------------------------------------------------
                ImagesModel images = new ImagesModel(hero.Images.ExtraSmall,
                                                     hero.Images.Small,
                                                     hero.Images.Medium,
                                                     hero.Images.Large);

                ///----------------Hero--------------------------------------------------------------------------

                HeroModel heroModel = new HeroModel();
                heroModel.Name = hero.Name;
                heroModel.Slug = hero.Slug;
                heroModel.PowerStats = powerStatsModel;
                heroModel.Appearance = appearance;
                heroModel.Biography = biography;
                heroModel.Work = workModel;
                heroModel.ConnectionsModel = connections;
                heroModel.Images = images;


                heroContext.HeroModel.Add(heroModel);
                heroContext.AppearanceModel.Add(appearance);
                heroContext.BiographyModel.Add(biography);

                foreach (var alias in aliases)
                {
                    heroContext.AliasesModel.Add(alias);
                }

                heroContext.ConnectionsModel.Add(connections);
                heroContext.HeightModel.Add(heightModel);
                heroContext.ImagesModel.Add(images);
                heroContext.PowerStatsModel.Add(powerStatsModel);
                heroContext.WeightModel.Add(weightModel);
                heroContext.WorkModel.Add(workModel);
                heroContext.SaveChanges();

            }

               
            

        }
    }
}
