using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HotelBookingsWeb.Model
{
    public class AirBnbContext : DbContext
    {
        public AirBnbContext(DbContextOptions<AirBnbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            IList<System_User> users = new List<System_User>();

            users.Add(new System_User()
            {
                Id = 1,
                Username = "admin",
                Password="123",
                Email="admin@mail.com",
                FullName="Admin",
                Contact = "111-333-1212",
                Role = "admin"
            });

            users.Add(new System_User()
            {
                Id = 2,
                Username = "admin1",
                Password="123",
                Email="admin1@mail.com",
                FullName="Admin 1",
                Contact = "11121-333-1212",
                Role = "admin"
            });

            IList<HotelInfo> hotels = new List<HotelInfo>();

            hotels.Add(new HotelInfo
            {
                Id = 1,
                City = "NY",
                HotelName = "NYC",
                NumberOfRooms = 500
            });

            hotels.Add(new HotelInfo
            {
                Id = 2,
                City = "NY",
                HotelName = "New Hotel",
                NumberOfRooms = 500
            });

            hotels.Add(new HotelInfo
            {
                Id = 3,
                City = "NY",
                HotelName = "My Hotel",
                NumberOfRooms = 500
            });
            hotels.Add(new HotelInfo
            {
                Id = 4,
                City = "NY",
                HotelName = "Cal Hotel",
                NumberOfRooms = 500
            });

            IList<Room> rooms = new List<Room>();

            rooms.Add(new Room
            {
                Id = 1,
                Number = "R - 001",
                PricePerNight = 200,
                Size = "20x20"
            });

            rooms.Add(new Room
            {
                Id = 2,
                Number = "R - 002",
                PricePerNight = 500,
                Size = "20x20"
            });

            rooms.Add(new Room
            {
                Id = 3,
                Number = "R - 003",
                PricePerNight = 100,
                Size = "20x20"
            });

            rooms.Add(new Room
            {
                Id = 4,
                Number = "R - 004",
                PricePerNight = 300,
                Size = "20x20"
            });

            modelBuilder.Entity<System_User>()
                    .HasData
                    (users);

            modelBuilder.Entity<HotelInfo>()
                    .HasData
                    (hotels);

            modelBuilder.Entity<Room>()
                    .HasData
                    (rooms);
        }

        public virtual DbSet<Reservation> Bookings { get; set; }
        public virtual DbSet<Extra> Extras { get; set; }
        public virtual DbSet<HotelInfo> HotelInfoes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Landlord> Landlords { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<System_User> System_Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}