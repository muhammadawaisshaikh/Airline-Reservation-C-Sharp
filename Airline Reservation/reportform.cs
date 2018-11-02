using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class reportform : Form
    {
        public reportform()
        {
            InitializeComponent();
        }

        private void reportform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AirlinesDataSet4.admindb' table. You can move, or remove it, as needed.
            this.admindbTableAdapter.Fill(this.AirlinesDataSet4.admindb);
            // TODO: This line of code loads data into the 'AirlinesDataSet3.employeedb' table. You can move, or remove it, as needed.
            this.employeedbTableAdapter.Fill(this.AirlinesDataSet3.employeedb);
            // TODO: This line of code loads data into the 'AirlinesDataSet2.routesdb' table. You can move, or remove it, as needed.
            this.routesdbTableAdapter.Fill(this.AirlinesDataSet2.routesdb);
            // flight reports
            this.flightdbTableAdapter.Fill(this.AirlinesDataSet1.flightdb);
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }

        private void resbut_Click(object sender, EventArgs e)
        {
            // reservation reports
            this.reservationdbTableAdapter.Fill(this.AirlinesDataSet.reservationdb,mobtext.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
