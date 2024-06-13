using HotelBookingsWeb.Model;
using AirBnbDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirBnbDesktop
{
    /// <summary>
    /// Interaction logic for ManageLandlord.xaml
    /// </summary>
    public partial class ManageLandlord : Window
    {
        public ManageLandlord()
        {
            InitializeComponent();
        }

        private void Update_Row(object sender, RoutedEventArgs e)
        {
            var selected = dglands.SelectedItem as Landlord;

            if (selected != null)
            {
                ((AdminViewModel)this.DataContext).Update(selected);
            }
        }

        private void Delete_Row(object sender, RoutedEventArgs e)
        {
            var selected = dglands.SelectedItem as Landlord;

            if (selected != null)
            {
                ((AdminViewModel)this.DataContext).Remove(selected.Id);
            }
        }
    }
}
