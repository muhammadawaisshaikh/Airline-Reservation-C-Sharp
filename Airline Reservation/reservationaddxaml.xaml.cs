using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for reservationaddxaml.xaml
    /// </summary>
    public partial class reservationaddxaml : Page
    {
        public reservationaddxaml()
        {
            InitializeComponent();

            // retrieve flights from flight table of database
            airlinqDataContext dc = new airlinqDataContext();

            var q = from a in dc.flightdbs
                    select a.name;

            foreach (var cust in q)
            {
                r4combo.Items.Add(cust);
            }

            r4combo.SelectedIndex = 0;


        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            home h = new home();
            this.NavigationService.Navigate(h);
        }

        private void r2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(r2.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Mobile Number !");
            }
        }

        private void r3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(r3.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter valid number of Passengers");
            }
        }

        

       

        private void resadd_Click(object sender, RoutedEventArgs e)
        {
            r1.Text = ""; r5.Text = ""; 
            r2.Text = "0"; r3.Text = "0"; r6.Text = "0"; r7.Text = "0";
        }

        private void ressaveb_Click(object sender, RoutedEventArgs e)
        {
            // INSERT CUSTOMER : CODE



            try
            {
                if (r1.Text == "" || r2.Text == "" || r3.Text == "" || r5.Text == "" || r6.Text == "" || r7.Text == ""  )
                {
                    MessageBox.Show("Don't Leave Any TextBox Empty !");
                }
                else
                {
                    var d = new airlinqDataContext();
                    var c = new reservationdb();

                    c.name = r1.Text;
                    c.mobile = r2.Text;
                    c.passengers = r3.Text;
                    c.flight = r4combo.Text;
                    c.route = r5.Text;
                    c.seats = r6.Text;
                    c.payment = r7.Text;

                    d.reservationdbs.InsertOnSubmit(c);
                    d.SubmitChanges();

                    r1.Text = ""; r5.Text = "";
                    r2.Text = "0"; r3.Text = "0"; r6.Text = "0"; r7.Text = "0";

                    MessageBox.Show("Inserted Successfully");
                } // else closing
            }
            catch
            {
                MessageBox.Show("Issue With Database Handling ! Contact Database Administrator");
            }
        }

        private void redsearch_Click(object sender, RoutedEventArgs e)
        {
            // SEARCH CUSTOMER : CODE

            try
            {

                if (r2.Text == "0" || r2.Text == "")
                {
                    MessageBox.Show("Search Customer Details By their Mobile Numbers .");
                }
                else { 
                airlinqDataContext dc = new airlinqDataContext();

                var q = from a in dc.reservationdbs
                        where a.mobile == r2.Text
                        select a;

                foreach (var cust in q)
                {
                    r1.Text = cust.name;
                    r2.Text = cust.mobile;
                    r3.Text = cust.passengers;
                    r4combo.SelectedValue = cust.flight;
                    r5.Text = cust.route;
                    r6.Text = cust.seats;
                    r7.Text = cust.payment;
                }
                }
            }
            catch
            {
                MessageBox.Show("Search Customer by means of their mobile numbers !");
            }
        }

        private void resmod_Click(object sender, RoutedEventArgs e)
        {
            // update customer details code

            try
            {
                if (r2.Text == "0" || r2.Text == "")
                {
                    MessageBox.Show("Search Customer Details By their Mobile Numbers & then Update .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var query = from person in dc.reservationdbs
                                where person.mobile == r2.Text
                                select person;

                    foreach (var cust in query)
                    {

                        cust.name = r1.Text;
                        cust.mobile = r2.Text;
                        cust.passengers = r3.Text;
                        cust.flight = r4combo.Text;
                        cust.route = r5.Text;
                        cust.seats = r6.Text;
                        cust.payment = r7.Text;

                    }
                    dc.SubmitChanges();

                    r1.Text = ""; r5.Text = "";
                    r2.Text = "0"; r3.Text = "0"; r6.Text = "0"; r7.Text = "0";

                } // else closing
            }

            catch
            {
                MessageBox.Show("Search Customer by means of their mobile numbers & then Update Their Details .");
            }
        }

        private void resdel_Click(object sender, RoutedEventArgs e)
        {
            // delete customer details code

            try
            {
                if (r2.Text == "0" || r2.Text == "")
                {
                    MessageBox.Show("Search Customer Details By their Mobile Numbers & then Delete .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();
                    var c = new reservationdb();

                    var q = from a in dc.reservationdbs
                            where a.mobile == r2.Text
                            select a;

                    foreach (var cust in q)
                    {
                        dc.reservationdbs.DeleteOnSubmit(cust);
                    }

                    dc.SubmitChanges();

                    r1.Text = ""; r5.Text = "";
                    r2.Text = "0"; r3.Text = "0"; r6.Text = "0"; r7.Text = "0";

                } // else closing
            }
            catch
            {
                MessageBox.Show("Search Customer by means of their mobile numbers & then Delete!");
            }
        }

       

        

       


       

       










        
    }
}
