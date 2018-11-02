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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airline_Reservation
{
    /// <summary>
    /// Interaction logic for reservation.xaml
    /// </summary>
    public partial class reservation : Page
    {
        public reservation()
        {
            InitializeComponent();

            reservationaddxaml ra = new reservationaddxaml();
            frameres.NavigationService.Navigate(ra);

        }

       
       
    }
}
