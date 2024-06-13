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
    /// Interaction logic for ManageProperties.xaml
    /// </summary>
    public partial class ManageProperties : Window
    {
        public ManageProperties()
        {
            InitializeComponent();
        }

        private void Delete_Row(object sender, RoutedEventArgs e)
        {
            var selected = dglands.SelectedItem as Property;

            if (selected != null)
            {
                ((PropertyViewModel)this.DataContext).Remove(selected.Id);
            }
        }

        private void Update_Row(object sender, RoutedEventArgs e)
        {
            var selected = dglands.SelectedItem as Property;

            if (selected != null)
            {
                ((PropertyViewModel)this.DataContext).Update(selected);
            }
        }
    }
}
