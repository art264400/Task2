using EF.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Hall> Halls { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Timeslot> Timeslots { get; set; }

        public DbSet<Tariff> Tariffs { get; set; }

        public DbSet<Country> Countries { get; set; }

        public ApplicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }





        //public override int SaveChanges()
        //{
        //    if (!ChangeTracker.HasChanges()) return 0;

        //    var changedEntities = ChangeTracker.Entries();

        //    foreach (var changedEntity in changedEntities)
        //    {
        //        if (!(changedEntity.Entity is IEntity)) continue;

        //        var entity = (IEntity)changedEntity.Entity;

        //        switch (changedEntity.State)
        //        {
        //            case EntityState.Added:
        //                entity.BeforeInsert();
        //                break;

        //            case EntityState.Modified:
        //                entity.BeforeUpdate();
        //                break;

        //            case EntityState.Detached:
        //                break;

        //            case EntityState.Unchanged:
        //                break;

        //            case EntityState.Deleted:
        //                break;

        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //    try
        //    {
        //        // base.Configuration.ValidateOnSaveEnabled = false;   //ВНИМАТЕЛЬНО!
        //        return base.SaveChanges();
        //    }
        //    catch (Exception exp/*DbEntityValidationException ex*/)
        //    {
        //        throw exp;// new xDbEntityValidationException(ex);
        //    }
        //}
    }
}
