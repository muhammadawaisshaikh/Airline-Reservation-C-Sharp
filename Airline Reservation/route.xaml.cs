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
    /// Interaction logic for route.xaml
    /// </summary>
    public partial class route : Page
    {
        public route()
        {
            InitializeComponent();


            // retrieve flights from flight table of database
            airlinqDataContext dc = new airlinqDataContext();

            var q = from a in dc.flightdbs
                    select a.name;

            foreach (var cust in q)
            {
                namet.Items.Add(cust);
            }

            namet.SelectedIndex = 0;





        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            home h = new home();
            this.NavigationService.Navigate(h);
        }

        private void rootnewb_Click(object sender, RoutedEventArgs e)
        {
              fromt.Text = ""; tot.Text = ""; takeofft.Text = ""; landt.Text = "";
            modelt.Text = "0";
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

        private void routesearch_Click(object sender, RoutedEventArgs e)
        {
            // SEARCH  : CODE

            try
            {

                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search route Details By flight model Numbers .");
                }
                else { 
                airlinqDataContext dc = new airlinqDataContext();

                var q = from a in dc.routesdbs
                        where a.model == modelt.Text
                        select a;

                foreach (var cust in q)
                {
                    namet.SelectedValue = cust.name;
                    modelt.Text = cust.model;
                    fromt.Text = cust.startdest;
                    tot.Text = cust.enddest;
                    takeofft.Text = cust.takeoff;
                    landt.Text = cust.landing;
                }
                }
            }
            catch
            {
                MessageBox.Show("Search route Details By flight model Numbers .");
            }
        }

        private void routesave_Click(object sender, RoutedEventArgs e)
        {
            // INSERT : CODE

         try
            {
                if (fromt.Text == ""|| tot.Text == ""|| takeofft.Text == ""|| landt.Text == ""|| modelt.Text == "0")
                {
                    MessageBox.Show("Don't Leave Any TextBox Empty !");
                }
                else
                {
                    var d = new airlinqDataContext();
                    var c = new routesdb();

                    c.name = namet.SelectedValue.ToString();
                    c.model = modelt.Text;
                    c.startdest = fromt.Text;
                    c.enddest = tot.Text;
                    c.takeoff = takeofft.Text;
                    c.landing = landt.Text;

                    d.routesdbs.InsertOnSubmit(c);
                    d.SubmitChanges();

                    fromt.Text = ""; tot.Text = ""; takeofft.Text = ""; landt.Text = "";
                    modelt.Text = "0";

                    MessageBox.Show("Inserted Successfully");
                } // else closing
            }
            catch
            {
                MessageBox.Show("Issue With Database Handling ! Contact Database Administrator");
            }
        }

        private void routemod_Click(object sender, RoutedEventArgs e)
        {
            // update details code

            try
            {
                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search route Details By flight model Numbers & then Update .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var query = from person in dc.routesdbs
                                where person.model == modelt.Text
                                select person;

                    foreach (var c in query)
                    {

                        c.name = namet.SelectedValue.ToString();
                        c.model = modelt.Text;
                        c.startdest = fromt.Text;
                        c.enddest = tot.Text;
                        c.takeoff = takeofft.Text;
                        c.landing = landt.Text;

                    }
                    dc.SubmitChanges();

                    fromt.Text = ""; tot.Text = ""; takeofft.Text = ""; landt.Text = "";
                    modelt.Text = "0";
                
                } // else closing
            }

            catch
            {
                MessageBox.Show("Search route Details By flight model Numbers & then Update Their Details .");
            }
        }

        private void routebin_Click(object sender, RoutedEventArgs e)
        {
            // delete  details code

            try
            {
                if (modelt.Text == "0" || modelt.Text == "")
                {
                    MessageBox.Show("Search route Details By flight model Numbers & then Delete .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();
                    var c = new reservationdb();

                    var q = from a in dc.routesdbs
                            where a.model == modelt.Text
                            select a;

                    foreach (var cust in q)
                    {
                        dc.routesdbs.DeleteOnSubmit(cust);
                    }

                    dc.SubmitChanges();

                    fromt.Text = ""; tot.Text = ""; takeofft.Text = ""; landt.Text = "";
                    modelt.Text = "0";
                
                } // else closing
            }
            catch
            {
                MessageBox.Show("Search route Details By flight model Numbers & then Delete!");
            }
        }

       

        
    }
}
