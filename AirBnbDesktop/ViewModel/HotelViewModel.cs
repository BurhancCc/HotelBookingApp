using AirBnbDesktop.Common;
using HotelBookingsWeb.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace AirBnbDesktop.ViewModel
{
    public class HotelViewModel : ViewModelBase
    {
        #region Private fields

        private ICommand _MainMenuClick;
        private DateTime _SelectedStartDate;
        private DateTime _SelectedEndDate;
        private Room _SelectedRoom;
        private HotelInfo _SelectedHotel;
        private string _HotelExtra;
        private ObservableCollection<HotelInfo> _Hotels;
        private ObservableCollection<Room> _Rooms;
        AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();

        #endregion Private fields

        #region Constructor

        public HotelViewModel(int hotelId)
        {
            MainMenuClick = new CommandHandler(new Action<object>(MainMenuClickClick));
            SelectedEndDate = SelectedStartDate = DateTime.Now;
            if (hotelId != null && hotelId > 0)
                LoadHotelRooms(hotelId);
            else
                LoadHotels();
        }

        #endregion Constructor

        #region private methods

        private void LoadHotels()
        {
            Hotels = new ObservableCollection<HotelInfo>(dbContext.HotelInfoes.ToList());
        }

        private void LoadHotelRooms(int hotelId)
        {
            Rooms = new ObservableCollection<Room>(dbContext.Rooms.ToList());
        }

        #endregion private methods

        #region Public Properties

        public ICommand MainMenuClick
        {
            get => _MainMenuClick;
            set
            {
                _MainMenuClick = value;
                OnPropertyChanged("MainMenuClick");
            }
        }

        public ObservableCollection<HotelInfo> Hotels
        {
            get => _Hotels;
            set
            {
                _Hotels = value;
                OnPropertyChanged("Hotels");
            }
        }

        public ObservableCollection<Room> Rooms
        {
            get => _Rooms;
            set
            {
                _Rooms = value;
                OnPropertyChanged("Rooms");
            }
        }

        public DateTime SelectedEndDate
        {
            get => _SelectedEndDate;
            set
            {
                _SelectedEndDate = value;
                OnPropertyChanged("SelectedEndDate");
            }
        }

        public DateTime SelectedStartDate
        {
            get => _SelectedStartDate;
            set
            {
                _SelectedStartDate = value;
                OnPropertyChanged("SelectedStartDate");
            }
        }

        public Room SelectedRoom
        {
            get => _SelectedRoom;
            set
            {
                _SelectedRoom = value;
                OnPropertyChanged("SelectedRoom");
            }
        }

        public HotelInfo SelectedHotel
        {
            get => _SelectedHotel;
            set
            {
                _SelectedHotel = value;
                OnPropertyChanged("SelectedHotel");
                HotelExtra = SelectedHotel.HotelName + " offers " + SelectedHotel.Extras.FirstOrDefault()?.ExtraDescription + " in extras.";
            }
        }

        public string HotelExtra
        {
            get => _HotelExtra;
            set
            {
                _HotelExtra = value;
                OnPropertyChanged("HotelExtra");
            }
        }

        #endregion Public Properties

        #region Command Methods

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

        #endregion Command Methods
    }
}