using HotelBookingsWeb.Model;
using HotelBookingsWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllReservations()
        {
            AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();
            var reservations = dbContext.Bookings
                .Include(x => x.Customer)
                .Include(x => x.Room)
                .Include(x => x.Property)
                .ToList();

            var reservationList = new List<CustomerReservation>();

            foreach (var res in reservations)
            {
                var customerReservation = new CustomerReservation
                {
                    BookingDays = res.BookingDays,
                    Contact = res?.Customer?.Contact,
                    Customer = res?.Customer?.FullName,
                    Email = res?.Customer?.Email,
                    EndDate = res.EndDate,
                    StartDate = res.StartDate,
                    TotalCharges = res.TotalCharges,
                    Room = res.Room?.Number,
                    Property = res?.Property?.PropertyName
                };

                reservationList.Add(customerReservation);
            }

            return View(reservationList);
        }
        public IActionResult CreateBooking()
        {
            AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();
            ViewBag.Rooms = dbContext.Rooms.ToList();
            ViewBag.Properties = dbContext.Properties.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult CreateBooking(CustomerReservation reservation)
        {
            if (ModelState.IsValid)
            {
                AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();

                Customer customer = new Customer
                {
                    FullName = reservation.Customer,
                    Contact = reservation.Contact,
                    Email = reservation.Email
                };

                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();

                Reservation res = new Reservation
                {
                    CustomerId = customer.Id,
                    StartDate = reservation.StartDate,
                    EndDate = reservation.EndDate,
                    TotalCharges = reservation.TotalCharges,
                    BookingDays = (int)(reservation.EndDate - reservation.StartDate).Value.TotalDays,
                    RoomId = reservation.RoomId,
                    PropertyId = reservation.PropertyId
                };

                dbContext.Bookings.Add(res);
                dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(AllReservations));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
