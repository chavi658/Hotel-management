using Microsoft.EntityFrameworkCore;
using restful.Entities;

namespace CreateApi
{
    public class DataContext:DbContext
    {

        public DbSet<Guest> guests { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Package> Packages { get; set; }
        //public DataContext()
        //{
        //    guests = new List<Guest>();
        //    guests.Add(new Guest() { Id = 7, Status = false, Phone = 0222 });
        //    guests.Add(new Guest() { Id = 5, Status = false, Phone = 89 });
        //    guests.Add(new Guest() { Id = 6, Status = true, Phone = 55 });

        //    rooms = new List<Room>();
        //    rooms.Add(new Room() { Id = 7, Avialable = false });
        //    rooms.Add(new Room() { Id = 6, Avialable = true });

        //    rooms.Add(new Room() { Id = 5, Avialable = false });

        //    Packages = new List<Package>();
        //    Packages.Add(new Package() { Id = 123, PachgeName = "xxx", Price = 30 });
        //    Packages.Add(new Package() { Id = 456, PachgeName = "yyy", Price = 33 });
        //    Packages.Add(new Package() { Id = 345, PachgeName = "zzz", Price = 34.5 });

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Guest_db");
        }






    }
}