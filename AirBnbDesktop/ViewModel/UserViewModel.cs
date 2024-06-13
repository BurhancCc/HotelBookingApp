using AirBnbDesktop.Common;
using HotelBookingsWeb.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace AirBnbDesktop.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private ICommand _LoginCommand;
        private ICommand _OpenRegisterClick;
        private ICommand _OpenLoginClick;
        private ICommand _AddNewUserClick;
        private ICommand _MainMenuClick;
        private string _username;
        private string _password;
        private string _FullName;
        private string _Gender;
        private string _Contact;
        private string _Email;
        private ObservableCollection<Reservation> _Bookings;
        private Reservation _SelectedBooking;

        AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();

        #region Constructor

        public UserViewModel()
        {
            LoginCommand = new CommandHandler(new Action<object>(Login));
            OpenRegisterClick = new CommandHandler(new Action<object>(OpenRegisterWindow));
            OpenLoginClick = new CommandHandler(new Action<object>(OpenLoginWindow));
            AddNewUserClick = new CommandHandler(new Action<object>(AddNewUser));
            if (Global.Loggeduser != null)
            {
                LoadBookings();
                MainMenuClick = new CommandHandler(new Action<object>(MainMenuClickClick));
            }
        }

        #endregion Constructor

        private void LoadBookings()
        {
            Bookings = new ObservableCollection<Reservation>(dbContext.Bookings.ToList());
        }

        #region Public Properties

        public ObservableCollection<Reservation> Bookings
        {
            get { return _Bookings; }
            set
            {
                _Bookings = value;
                OnPropertyChanged("Bookings");
            }
        }

        public Reservation SelectedBooking
        {
            get { return _SelectedBooking; }
            set
            {
                _SelectedBooking = value;
                OnPropertyChanged("SelectedBooking");
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public string Contact
        {
            get { return _Contact; }
            set
            {
                _Contact = value;
                OnPropertyChanged("Contact");
            }
        }

        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
                OnPropertyChanged("Gender");
            }
        }

        public ICommand LoginCommand
        {
            get { return _LoginCommand; }
            set
            {
                _LoginCommand = value;
                OnPropertyChanged("LoginCommand");
            }
        }

        public ICommand OpenRegisterClick
        {
            get { return _OpenRegisterClick; }
            set
            {
                _OpenRegisterClick = value;
                OnPropertyChanged("OpenRegisterClick");
            }
        }

        public ICommand OpenLoginClick
        {
            get { return _OpenLoginClick; }
            set
            {
                _OpenLoginClick = value;
                OnPropertyChanged("OpenLoginClick");
            }
        }

        public ICommand AddNewUserClick
        {
            get { return _AddNewUserClick; }
            set
            {
                _AddNewUserClick = value;
                OnPropertyChanged("AddNewUserClick");
            }
        }

        public ICommand MainMenuClick
        {
            get => _MainMenuClick;
            set
            {
                _MainMenuClick = value;
                OnPropertyChanged("MainMenuClick");
            }
        }

        #endregion Public Properties

        #region Command Method

        private void MainMenuClickClick(object p = null)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new AdminWindow();
                    mainWin.Show();

                    item.Close();
                }
            }
        }

        private void AddNewUser(object p = null)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Contact) || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(FullName))
            {
                MessageBox.Show("Please provide all details");
                return;
            }
            else
            {
                var _loggedUser = new System_User();
                _loggedUser.Contact = Contact;
                _loggedUser.FullName = FullName;
                _loggedUser.Email = Email;
                _loggedUser.Password = Password;
                _loggedUser.Username = Username;
                _loggedUser.Role = Global.admin;
                dbContext.System_Users.Add(_loggedUser);
                dbContext.SaveChanges();

                MessageBox.Show("Registered Successfullly!");
                Global.Loggeduser = _loggedUser;
                foreach (Window item in Application.Current.Windows)
                {
                    if (item.DataContext == this)
                    {
                        Window mainWin = new MainWindow();
                        mainWin.Show();

                        item.Close();
                    }
                }
            }
        }

        private void Login(object p = null)
        {
            System_User user = dbContext.System_Users.SingleOrDefault(x => x.Username == Username && x.Password == Password);

            if (user != null)
            {
                Global.Loggeduser = user;
                foreach (Window item in Application.Current.Windows)
                {
                    if (item.DataContext == this)
                    {
                        Window mainWin = new AdminWindow();
                        mainWin.Show();

                        item.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("User Not Available");
            }
        }

        private void OpenRegisterWindow(object p = null)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new Register();
                    mainWin.Show();

                    item.Close();
                }
            }
        }

        private void OpenLoginWindow(object p = null)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new MainWindow();
                    mainWin.Show();

                    item.Close();
                }
            }
        }

        #endregion Command Method

        public void DeleteBooking()
        {
            var booking = dbContext.Bookings.SingleOrDefault(x => x.Id == SelectedBooking.Id);

            if (booking != null)
            {
                dbContext.Bookings.Remove(booking);
                dbContext.SaveChanges();
                MessageBox.Show("Booking deleted Successfullly!");
                LoadBookings();
            }
        }

        public void UpdateBooking()
        {
            var booking = dbContext.Bookings.SingleOrDefault(x => x.Id == SelectedBooking.Id);

            if (booking != null)
            {
                booking.BookingDays = SelectedBooking.BookingDays;
                booking.EndDate = SelectedBooking.EndDate;
                booking.StartDate = SelectedBooking.StartDate;
                booking.TotalCharges = SelectedBooking.TotalCharges;

                dbContext.SaveChanges();
                MessageBox.Show("Booking Updated Successfullly!");
                LoadBookings();
            }
            else
                MessageBox.Show("Error Updating Booking!");
        }
    }
}