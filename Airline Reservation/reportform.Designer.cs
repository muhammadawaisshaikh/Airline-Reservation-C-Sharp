namespace Airline_Reservation
{
    partial class reportform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportform));
            this.reservationdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlinesDataSet = new Airline_Reservation.AirlinesDataSet();
            this.flightdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlinesDataSet1 = new Airline_Reservation.AirlinesDataSet1();
            this.routesdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlinesDataSet2 = new Airline_Reservation.AirlinesDataSet2();
            this.employeedbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlinesDataSet3 = new Airline_Reservation.AirlinesDataSet3();
            this.admindbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlinesDataSet4 = new Airline_Reservation.AirlinesDataSet4();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resbut = new System.Windows.Forms.Button();
            this.mobtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reservationdbTableAdapter = new Airline_Reservation.AirlinesDataSetTableAdapters.reservationdbTableAdapter();
            this.flightdbTableAdapter = new Airline_Reservation.AirlinesDataSet1TableAdapters.flightdbTableAdapter();
            this.routesdbTableAdapter = new Airline_Reservation.AirlinesDataSet2TableAdapters.routesdbTableAdapter();
            this.employeedbTableAdapter = new Airline_Reservation.AirlinesDataSet3TableAdapters.employeedbTableAdapter();
            this.admindbTableAdapter = new Airline_Reservation.AirlinesDataSet4TableAdapters.admindbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationdbBindingSource
            // 
            this.reservationdbBindingSource.DataMember = "reservationdb";
            this.reservationdbBindingSource.DataSource = this.AirlinesDataSet;
            // 
            // AirlinesDataSet
            // 
            this.AirlinesDataSet.DataSetName = "AirlinesDataSet";
            this.AirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightdbBindingSource
            // 
            this.flightdbBindingSource.DataMember = "flightdb";
            this.flightdbBindingSource.DataSource = this.AirlinesDataSet1;
            // 
            // AirlinesDataSet1
            // 
            this.AirlinesDataSet1.DataSetName = "AirlinesDataSet1";
            this.AirlinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesdbBindingSource
            // 
            this.routesdbBindingSource.DataMember = "routesdb";
            this.routesdbBindingSource.DataSource = this.AirlinesDataSet2;
            // 
            // AirlinesDataSet2
            // 
            this.AirlinesDataSet2.DataSetName = "AirlinesDataSet2";
            this.AirlinesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeedbBindingSource
            // 
            this.employeedbBindingSource.DataMember = "employeedb";
            this.employeedbBindingSource.DataSource = this.AirlinesDataSet3;
            // 
            // AirlinesDataSet3
            // 
            this.AirlinesDataSet3.DataSetName = "AirlinesDataSet3";
            this.AirlinesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admindbBindingSource
            // 
            this.admindbBindingSource.DataMember = "admindb";
            this.admindbBindingSource.DataSource = this.AirlinesDataSet4;
            // 
            // AirlinesDataSet4
            // 
            this.AirlinesDataSet4.DataSetName = "AirlinesDataSet4";
            this.AirlinesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resbut);
            this.tabPage1.Controls.Add(this.mobtext);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // resbut
            // 
            this.resbut.Location = new System.Drawing.Point(376, 10);
            this.resbut.Name = "resbut";
            this.resbut.Size = new System.Drawing.Size(79, 33);
            this.resbut.TabIndex = 3;
            this.resbut.Text = "Search";
            this.resbut.UseVisualStyleBackColor = true;
            this.resbut.Click += new System.EventHandler(this.resbut_Click);
            // 
            // mobtext
            // 
            this.mobtext.Location = new System.Drawing.Point(192, 14);
            this.mobtext.Name = "mobtext";
            this.mobtext.Size = new System.Drawing.Size(172, 27);
            this.mobtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Route";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reservationdbBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Airline_Reservation.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(797, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flights";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.flightdbBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Airline_Reservation.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(803, 479);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(803, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Routes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "RouteDataSet";
            reportDataSource3.Value = this.routesdbBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Airline_Reservation.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(803, 475);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 475);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employees";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "EmployeeDataSet";
            reportDataSource4.Value = this.employeedbBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Airline_Reservation.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(803, 475);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(803, 475);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Admins";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource5.Name = "adminDataSet";
            reportDataSource5.Value = this.admindbBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Airline_Reservation.Report5.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(803, 479);
            this.reportViewer5.TabIndex = 0;
            // 
            // reservationdbTableAdapter
            // 
            this.reservationdbTableAdapter.ClearBeforeFill = true;
            // 
            // flightdbTableAdapter
            // 
            this.flightdbTableAdapter.ClearBeforeFill = true;
            // 
            // routesdbTableAdapter
            // 
            this.routesdbTableAdapter.ClearBeforeFill = true;
            // 
            // employeedbTableAdapter
            // 
            this.employeedbTableAdapter.ClearBeforeFill = true;
            // 
            // admindbTableAdapter
            // 
            this.admindbTableAdapter.ClearBeforeFill = true;
            // 
            // reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 508);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportform";
            this.Text = "REPORTINGS";
            this.Load += new System.EventHandler(this.reportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlinesDataSet4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reservationdbBindingSource;
        private AirlinesDataSet AirlinesDataSet;
        private AirlinesDataSetTableAdapters.reservationdbTableAdapter reservationdbTableAdapter;
        private System.Windows.Forms.Button resbut;
        private System.Windows.Forms.TextBox mobtext;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource flightdbBindingSource;
        private AirlinesDataSet1 AirlinesDataSet1;
        private AirlinesDataSet1TableAdapters.flightdbTableAdapter flightdbTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource routesdbBindingSource;
        private AirlinesDataSet2 AirlinesDataSet2;
        private AirlinesDataSet2TableAdapters.routesdbTableAdapter routesdbTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource employeedbBindingSource;
        private AirlinesDataSet3 AirlinesDataSet3;
        private AirlinesDataSet3TableAdapters.employeedbTableAdapter employeedbTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource admindbBindingSource;
        private AirlinesDataSet4 AirlinesDataSet4;
        private AirlinesDataSet4TableAdapters.admindbTableAdapter admindbTableAdapter;
    }
}