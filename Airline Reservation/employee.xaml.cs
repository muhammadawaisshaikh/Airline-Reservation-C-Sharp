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
    /// Interaction logic for employee.xaml
    /// </summary>
    public partial class employee : Page
    {
        public employee()
        {
            InitializeComponent();

            gendercombo.Items.Add("Male");
            gendercombo.Items.Add("Female");

            gendercombo.SelectedIndex = 0;


        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            home h = new home();
            this.NavigationService.Navigate(h);
        }

        private void et6_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value;

            if (int.TryParse(mobilet.Text, out value))
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("Enter valid Mobile Number");
            }
        }

        private void empnewb_Click(object sender, RoutedEventArgs e)
        {
            firstt.Text = ""; lastt.Text = ""; nationalityt.Text = ""; addresst.Text = ""; emailt.Text = ""; departt.Text = ""; positiont.Text = ""; feildt.Text = "";
            mobilet.Text = "0";
        }

        private void empsave_Click(object sender, RoutedEventArgs e)
        {
            // INSERT  : CODE



            try
            {
                if (firstt.Text == ""|| lastt.Text == ""|| nationalityt.Text == ""|| addresst.Text == ""|| emailt.Text == ""|| departt.Text == ""|| positiont.Text == ""|| feildt.Text == ""|| mobilet.Text == "0")
                {
                    MessageBox.Show("Don't Leave Any TextBox Empty !");
                }
                else
                {
                    var d = new airlinqDataContext();
                    var c = new employeedb();

                      c.first =firstt.Text;
                      c.last=lastt.Text;
                      c.gender=gendercombo.SelectedValue.ToString();
                      c.nationality=nationalityt.Text;
                      c.joining=datet.SelectedDate;
                      c.mobile=mobilet.Text ;
                      c.address=addresst.Text;
                      c.email=emailt.Text;
                      c.department=departt.Text;
                      c.position=positiont.Text;
                      c.field=feildt.Text;

                    d.employeedbs.InsertOnSubmit(c);
                    d.SubmitChanges();

                    firstt.Text = ""; lastt.Text = ""; nationalityt.Text = ""; addresst.Text = ""; emailt.Text = ""; departt.Text = ""; positiont.Text = ""; feildt.Text = "";
                    mobilet.Text = "0";
                    
                    MessageBox.Show("Inserted Successfully");
                } // else closing
            }
            catch
            {
                MessageBox.Show("Issue With Database Handling ! Contact Database Administrator");
            }
        }

        private void empsearch_Click(object sender, RoutedEventArgs e)
        {
            // SEARCH : CODE

            try
            {

                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Employee Details By their Mobile Numbers .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var q = from a in dc.employeedbs
                            where a.mobile == mobilet.Text
                            select a;

                    foreach (var emp in q)
                    {
                        firstt.Text = emp.first;
                        lastt.Text = emp.last;
                        gendercombo.SelectedValue = emp.gender;
                        nationalityt.Text = emp.nationality;
                        datet.SelectedDate = emp.joining;
                        mobilet.Text = emp.mobile;
                        addresst.Text = emp.address;
                        emailt.Text = emp.email;
                        departt.Text = emp.department;
                        positiont.Text = emp.position;
                        feildt.Text = emp.field;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Search Employee by means of their mobile numbers !");
            }
        }

        private void empmod_Click(object sender, RoutedEventArgs e)
        {
            // update  details code

            try
            {
                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Employee Details By their Mobile Numbers & then Update .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();

                    var query = from person in dc.employeedbs
                                where person.mobile == mobilet.Text
                                select person;

                    foreach (var c in query)
                    {

                        c.first = firstt.Text;
                        c.last = lastt.Text;
                        c.gender = gendercombo.SelectedValue.ToString();
                        c.nationality = nationalityt.Text;
                        c.joining = datet.SelectedDate;
                        c.mobile = mobilet.Text;
                        c.address = addresst.Text;
                        c.email = emailt.Text;
                        c.department = departt.Text;
                        c.position = positiont.Text;
                        c.field = feildt.Text;

                    }
                    dc.SubmitChanges();

                    firstt.Text = ""; lastt.Text = ""; nationalityt.Text = ""; addresst.Text = ""; emailt.Text = ""; departt.Text = ""; positiont.Text = ""; feildt.Text = "";
                    mobilet.Text = "0";
                
                } // else closing
            }

            catch
            {
                MessageBox.Show("Search Employee by means of their mobile numbers & then Update Their Details .");
            }
        }

        private void empbin_Click(object sender, RoutedEventArgs e)
        {
            // delete  details code

            try
            {
                if (mobilet.Text == "0" || mobilet.Text == "")
                {
                    MessageBox.Show("Search Employee Details By their Mobile Numbers & then Delete .");
                }
                else
                {
                    airlinqDataContext dc = new airlinqDataContext();
                    var c = new reservationdb();

                    var q = from a in dc.employeedbs
                            where a.mobile == mobilet.Text
                            select a;

                    foreach (var cust in q)
                    {
                        dc.employeedbs.DeleteOnSubmit(cust);
                    }

                    dc.SubmitChanges();

                    firstt.Text = ""; lastt.Text = ""; nationalityt.Text = ""; addresst.Text = ""; emailt.Text = ""; departt.Text = ""; positiont.Text = ""; feildt.Text = "";
                    mobilet.Text = "0";
                
                } // else closing
            }
            catch
            {
                MessageBox.Show("Search Employee by means of their mobile numbers & then Delete!");
            }
        }


    }
}
