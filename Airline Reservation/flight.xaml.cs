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
    /// Interaction logic for flight.xaml
    /// </summary>
    public partial class flight : Page
    {
        public flight()
        {
            InitializeComponent();
        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            home h = new home();
            this.NavigationService.Navigate(h);
        }

       

       

        private void flightnew_Click(object sender, RoutedEventArgs e)
        {
            namet.Text = ""; typet.Text = ""; takeofft.Text = ""; landingt.Text = "";
            modelt.Text = "0"; seatt.Text = "0"; cabint.Text = "0";
        }

        private void modelt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(modelt.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Model in Numeric format !");
            }
        }

        private void seatt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(seatt.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Number of Seats !");
            }
        }

        private void cabint_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(cabint.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Number of Cabins !");
            }
        }

        private void flightsaveb_Click(object sender, RoutedEventArgs e)
        {
            // INSERT  : CODE

            try
            {
                if (namet.Text == ""|| typet.Text == ""|| takeofft.Text == ""|| landingt.Text == ""|| modelt.Text == "0"|| seatt.Text == "0"|| cabint.Text == "0" )
                {
                    MessageBox.Show("Don't Leave Any TextBox Empty !");
                }
                else
                {
                    var d = new airlinqDataContext();
                    var c = new flightdb();

                    c.name = namet.Text;
                    c.type = typet.Text;
                    c.model = modelt.Text;
                    c.seats = seatt.Text;
                    c.cabins = cabint.Text;
                    c.takoff = takeofft.Text;
                    c.landing = landingt.Text;
                    
                    d.flightdbs.InsertOnSubmit(c);
                    d.SubmitChanges();

                    namet.Text = ""; typet.Text = ""; takeofft.Text = ""; landingt.Text = "";
                    modelt.Text = "0"; seatt.Text = "0"; cabint.Text = "0";
                    
                    MessageBox.Show("Inserted Successfully");
                } // else closing
            }
            catch
            {
                MessageBox.Show("Issue With Database Handling ! Contact Database Administrator");
            }
        }

        private void flightsearch_Click(object sender, RoutedEventArgs e)
        {
            // SEARCH CUSTOMER : CODE

            try
            {

                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search Flight Details By their Model Numbers .");
                }

                airlinqDataContext dc = new airlinqDataContext();

                var q = from a in dc.flightdbs
                        where a.model == modelt.Text
                        select a;

                foreach (var cust in q)
                {
                    namet.Text = cust.name;
                    typet.Text = cust.type;
                    modelt.Text = cust.model;
                    seatt.Text = cust.seats;
                    cabint.Text = cust.cabins;
                    takeofft.Text = cust.takoff;
                    landingt.Text = cust.landing;
                    
                }

            }
            catch
            {
                MessageBox.Show("Search flight by means of their model numbers !");
            }
        }

        private void flightmod_Click(object sender, RoutedEventArgs e)
        {
            // update customer details code

            try
            {
                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search flight by means of their model numbers & then Update .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var query = from person in dc.flightdbs
                                where person.model == modelt.Text
                                select person;

                    foreach (var c in query)
                    {
                        c.name = namet.Text;
                        c.type = typet.Text;
                        c.model = modelt.Text;
                        c.seats = seatt.Text;
                        c.cabins = cabint.Text;
                        c.takoff = takeofft.Text;
                        c.landing = landingt.Text;
                    }
                    dc.SubmitChanges();

                    namet.Text = ""; typet.Text = ""; takeofft.Text = ""; landingt.Text = "";
                    modelt.Text = "0"; seatt.Text = "0"; cabint.Text = "0";
                
                } // else closing
            }

            catch
            {
                MessageBox.Show("Search flight by means of their model numbers & then Update Their Details .");
            }
        }

        private void flightbin_Click(object sender, RoutedEventArgs e)
        {
            // delete customer details code

            try
            {
                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search flight by means of their model numbers & then Delete .");
                }
                else
                {

                    airlinqDataContext dc = new airlinqDataContext();

                    var q = from a in dc.flightdbs
                            where a.model == modelt.Text
                            select a;

                    foreach (var cust in q)
                    {
                        dc.flightdbs.DeleteOnSubmit(cust);
                    }

                    dc.SubmitChanges();

                    namet.Text = ""; typet.Text = ""; takeofft.Text = ""; landingt.Text = "";
                    modelt.Text = "0"; seatt.Text = "0"; cabint.Text = "0";
                
                } // else closing
            }
            catch
            {
                MessageBox.Show("Search flight by means of their model numbers & then Delete!");
            }
        }

        
    }
}
