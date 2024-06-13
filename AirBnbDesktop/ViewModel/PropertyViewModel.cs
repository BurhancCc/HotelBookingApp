using HotelBookingsWeb.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace AirBnbDesktop.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        #region Private fields

        private ICommand _AddPropertyCommand;
        private Property _Property;
        private ObservableCollection<Property> _Properties;
        private ObservableCollection<Landlord> _landlords;
        private ICommand _MainMenuClick;
        private AirBnbContext dbContext = new AirBnbContextDbContextFactory().CreateDbContext();

        #endregion Private fields

        #region Constructor

        public PropertyViewModel()
        {
            Property = new Property();
            AddPropertyCommand = new CommandHandler(new Action<object>(AddPropertyCommandClick));
            Landlords = new ObservableCollection<Landlord>(dbContext.Landlords.ToList());
            MainMenuClick = new CommandHandler(new Action<object>(MainMenuClickClick));
            LoadProperties();
        }

        #endregion Constructor

        #region Public Properties

        public ICommand AddPropertyCommand
        {
            get => _AddPropertyCommand;
            set
            {
                _AddPropertyCommand = value;
                OnPropertyChanged("AddPropertyCommand");
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

        public Property Property
        {
            get => _Property;
            set
            {
                _Property = value;
                OnPropertyChanged("Property");
            }
        }

        public ObservableCollection<Property> Properties
        {
            get => _Properties;
            set
            {
                _Properties = value;
                OnPropertyChanged("Properties");
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

        #endregion Public Properties

        public void LoadProperties()
        {
            Properties = new ObservableCollection<Property>(dbContext.Properties.ToList());
        }

        #region Command Methods

        private void AddPropertyCommandClick(object p = null)
        {
            if (Property != null)
            {
                dbContext.Properties.Add(Property);
                dbContext.SaveChanges();
                LoadProperties();
                MessageBox.Show("Property Added");
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

        public void Update(Property p)
        {
            var prop = dbContext.Properties.SingleOrDefault(x => x.Id == p.Id);

            if (prop != null)
            {
                prop.Location = p.Location;
                prop.PropertyName = p.PropertyName;
                prop.PropertyType = p.PropertyType;
                prop.RoomsCount = p.RoomsCount;

                dbContext.SaveChanges();
                LoadProperties();
                MessageBox.Show("Property Updated");
            }
        }

        public void Remove(int pId)
        {
            var prop = dbContext.Properties.SingleOrDefault(x => x.Id == pId);

            if (prop != null)
            {
                dbContext.Properties.Remove(prop);
                dbContext.SaveChanges();
                LoadProperties();
                MessageBox.Show("Property Deleted");
            }
        }

        #endregion Command Methods
    }
}