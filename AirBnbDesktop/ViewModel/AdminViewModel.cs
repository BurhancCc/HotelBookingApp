using HotelBookingsWeb.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirBnbDesktop.ViewModel
{
    public class AdminViewModel : ViewModelBase
    {
        #region Private fields

        private ICommand _Logout;
        private ICommand _ManageLandlords;
        private ICommand _ManageProperties;
        private ICommand _Reservations;
        private ICommand _ManageCustomers;
        private ICommand _AddLandlordCommand;
        private ICommand _MainMenuClick;
        private Landlord _landlord;
        private ObservableCollection<Landlord> _landlords;
        AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();

        #endregion

        #region Constructor
        public AdminViewModel()
        {
            Landlord = new Landlord();
            ManageLandlords = new CommandHandler(new Action<object>(ManageLandlordsClick));
            ManageProperties = new CommandHandler(new Action<object>(ManagePropertiesClick));

            Logout = new CommandHandler(new Action<object>(LogoutClick));
            AddLandlordCommand = new CommandHandler(new Action<object>(AddLandlordCommandClick));
            Reservations = new CommandHandler(new Action<object>(ReservationsCommandClick));
            MainMenuClick = new CommandHandler(new Action<object>(MainMenuClickClick));

            LoadLandLords();
        }
        #endregion

        #region Public Properties
        public ICommand ManageLandlords
        {
            get => _ManageLandlords;
            set
            {
                _ManageLandlords = value;
                OnPropertyChanged("ManageLandlords");
            }
        }
        public ICommand Logout
        {
            get => _Logout;
            set
            {
                _Logout = value;
                OnPropertyChanged("Logout");
            }
        }
        public ICommand ManageProperties
        {
            get => _ManageProperties;
            set
            {
                _ManageProperties = value;
                OnPropertyChanged("ManageProperties");
            }
        }
        public ICommand ManageCustomers
        {
            get => _ManageCustomers;
            set
            {
                _ManageCustomers = value;
                OnPropertyChanged("ManageCustomers");
            }
        }
        public ICommand AddLandlordCommand
        {
            get => _AddLandlordCommand;
            set
            {
                _AddLandlordCommand = value;
                OnPropertyChanged("AddLandlordCommand");
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
        public ICommand Reservations
        {
            get => _Reservations;
            set
            {
                _Reservations = value;
                OnPropertyChanged("Reservations");
            }
        }
        public Landlord Landlord
        {
            get => _landlord;
            set
            {
                _landlord = value;
                OnPropertyChanged("Landlord");
            }
        }
        public ObservableCollection<Landlord> Landlords
        {
            get => _landlords;
            set
            {
                _landlords = value;
                OnPropertyChanged("Landlords");
            }
        }

        #endregion

        public void LoadLandLords()
        {
            Landlords = new ObservableCollection<Landlord>(dbContext.Landlords.ToList());
        }

        #region Command Methods
        private void LogoutClick(object p = null)
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
        private void ManageLandlordsClick(object p = null)
        {

            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new ManageLandlord();
                    mainWin.Show();

                    item.Close();
                }
            }
        }
        private void ManagePropertiesClick(object p = null)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new ManageProperties();
                    mainWin.Show();

                    item.Close();
                }
            }
        }
        private void AddLandlordCommandClick(object p = null)
        {
            if (Landlord != null)
            {
                dbContext.Landlords.Add(Landlord);
                dbContext.SaveChanges();
                LoadLandLords();
                MessageBox.Show("Landlord Added");
            }
        }
        private void ReservationsCommandClick(object p = null)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    Window mainWin = new ViewBookings();
                    mainWin.Show();

                    item.Close();
                }
            }
        }
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

        public void Update(Landlord landlord)
        {
            var ll = dbContext.Landlords.SingleOrDefault(x => x.Id == landlord.Id);

            if (ll != null)
            {
                ll.FullName = landlord.FullName;
                ll.Email = landlord.Email;
                ll.Address = landlord.Address;
                ll.Phone = landlord.Phone;

                dbContext.SaveChanges();
                LoadLandLords();
                MessageBox.Show("Landlord Updated");
            }
        }
        public void Remove(int landlordId)
        {
            var ll = dbContext.Landlords.SingleOrDefault(x => x.Id == landlordId);

            if (ll != null)
            {
                try
                {
                    dbContext.Landlords.Remove(ll);
                    dbContext.SaveChanges();
                    LoadLandLords();
                    MessageBox.Show("Landlord Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete Landlord having properties");
                }
                
            }
        }
        #endregion
    }
}
