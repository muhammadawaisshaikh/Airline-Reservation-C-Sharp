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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        public admin()
        {
            InitializeComponent();
        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            home h = new home();
            this.NavigationService.Navigate(h);
        }

       
        

        private void adminnewb_Click(object sender, RoutedEventArgs e)
        {
            namet.Text = ""; mobilet.Text = "0"; nict.Text = "0"; passt.Password = ""; cpasst.Password = "";
        }

        private void adminsave_Click(object sender, RoutedEventArgs e)
        {
            // INSERT : CODE



            try
            {
                if (namet.Text == "" || mobilet.Text == "" || nict.Text == "" || passt.Password == "" || cpasst.Password == "" )
                {
                    MessageBox.Show("Don't Leave Any TextBox Empty !");
                }
                else
                {
                    var d = new airlinqDataContext();
                    var c = new admindb();

                    c.name = namet.Text;
                    c.mobile = mobilet.Text;
                    c.nic = nict.Text;
                    c.pass = passt.Password;
                    c.cpass = cpasst.Password;

                    d.admindbs.InsertOnSubmit(c);
                    d.SubmitChanges();

                    namet.Text = ""; mobilet.Text = "0"; nict.Text = "0"; passt.Password = ""; cpasst.Password = "";

                    MessageBox.Show("Inserted Successfully");
                } // else closing
            }
            catch
            {
                MessageBox.Show("Issue With Database Handling ! Contact Database Administrator");
            }
        }

        private void adminsearch_Click(object sender, RoutedEventArgs e)
        {
            // SEARCH : CODE

            try
            {

                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Admin Details By their Mobile Numbers .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var q = from a in dc.admindbs
                            where a.mobile == mobilet.Text
                            select a;

                    foreach (var cust in q)
                    {
                        namet.Text = cust.name;
                        mobilet.Text = cust.mobile;
                        nict.Text = cust.nic;
                        passt.Password = cust.pass;
                        cpasst.Password = cust.cpass;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Search Admin by means of their mobile numbers !");
            }
        }

        private void adminmod_Click(object sender, RoutedEventArgs e)
        {
            // update details code

            try
            {
                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Admin Details By their Mobile Numbers & then Update .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var query = from person in dc.admindbs
                                where person.mobile == mobilet.Text
                                select person;

                    foreach (var c in query)
                    {

                        c.name = namet.Text;
                        c.mobile = mobilet.Text;
                        c.nic = nict.Text;
                        c.pass = passt.Password;
                        c.cpass = cpasst.Password;

                    }
                    dc.SubmitChanges();

                    namet.Text = ""; mobilet.Text = "0"; nict.Text = "0"; passt.Password = ""; cpasst.Password = "";

                
                } // else closing
            }

            catch
            {
                MessageBox.Show("Search Admin by means of their mobile numbers & then Update Their Details .");
            }
        }

        private void adminbin_Click(object sender, RoutedEventArgs e)
        {
            // delete details code

            try
            {
                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Delete Details By their Mobile Numbers & then Delete .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();
                    var c = new reservationdb();

                    var q = from a in dc.admindbs
                            where a.mobile == mobilet.Text
                            select a;

                    foreach (var cust in q)
                    {
                        dc.admindbs.DeleteOnSubmit(cust);
                    }

                    dc.SubmitChanges();

                    namet.Text = ""; mobilet.Text = "0"; nict.Text = "0"; passt.Password = ""; cpasst.Password = "";
                } // else closing
            }
            catch
            {
                MessageBox.Show("Search Delete by means of their mobile numbers & then Delete!");
            }
        }

        private void mobilet_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(mobilet.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Model in Numeric format !");
            }
        }

        private void nict_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(nict.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter a Valid Model in Numeric format !");
            }
        }
    }
}
