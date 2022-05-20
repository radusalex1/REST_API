using Microsoft.EntityFrameworkCore;
using REST_API.Models;

namespace REST_API.Data
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options):base(options)
        {

        }

        public HeroContext()
        {

        }

        public DbSet<HeroModel> HeroModel { get; set; }
        public DbSet<AppearanceModel> AppearanceModel { get; set; }
        public DbSet<BiographyModel> BiographyModel { get; set; }   
        public DbSet<ConnectionsModel> ConnectionsModel { get; set; }
        public DbSet<ImagesModel> ImagesModel { get; set; } 
        public DbSet<PowerStatsModel> PowerStatsModel { get; set; }
        public DbSet<WorkModel> WorkModel { get; set; }
        public DbSet<HeightModel> HeightModel { get; set; }
        public DbSet<WeightModel> WeightModel { get; set; }
        public DbSet<AliasesModel> AliasesModel { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<HeroModel>().ToTable("T_Heroes");
            model.Entity<AppearanceModel>().ToTable("T_Appearance");
            model.Entity<BiographyModel>().ToTable("T_Biography");
            model.Entity<ConnectionsModel>().ToTable("T_Connections");
            model.Entity<ImagesModel>().ToTable("T_Images");
            model.Entity<PowerStatsModel>().ToTable("T_PowerStats");
            model.Entity<WorkModel>().ToTable("T_Work");
            model.Entity<HeightModel>().ToTable("T_Height");
            model.Entity<WeightModel>().ToTable("T_Weight");
            model.Entity<AliasesModel>().ToTable("T_Aliases");

        }

        //internal void UpdateGraph<T>(HeroModel hero, Func<object, Range> p)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateGraph(object hero, Func<object, object> p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
