using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProjectGAI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public Reports(int N)
            : this()
        {
            n = N;


        }

        private int n;
        private void Form2_Load(object sender, EventArgs e)
        {
            switch (n)
            {
                case 1:
                    {
                        reportViewer1.Reset();
                        ReportDataSource reportDataSource1 = new ReportDataSource();
                        reportDataSource1.Name = "DataSet1";
                        reportDataSource1.Value = this.CaroOwnersBindingSource;
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGAI.Report.Report1.rdlc";
                        CaroOwnersTableAdapter.Fill(this.GAIDataSet.CaroOwners);
                        break;
                    }
                case 2:
                    {
                        reportViewer1.Reset();
                        ReportDataSource reportDataSource1 = new ReportDataSource();
                        reportDataSource1.Name = "DataSet1";
                        reportDataSource1.Value = this.OwnerFineBindingSource;
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGAI.Report.Report3.rdlc";
                        OwnerFineTableAdapter.Fill(this.GAIDataSet.OwnerFine);
                        break;
                    }
                case 3:
                    {
                        reportViewer1.Reset();
                        ReportDataSource reportDataSource1 = new ReportDataSource();
                        reportDataSource1.Name = "DataSet1";
                        reportDataSource1.Value = this.RightBindingSource;
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGAI.Report.Report4.rdlc";
                        RightTableAdapter.Fill(this.GAIDataSet.Right);
                        break;
                    }
                case 4:
                    {
                        reportViewer1.Reset();
                        ReportDataSource reportDataSource1 = new ReportDataSource();
                        reportDataSource1.Name = "DataSet1";
                        reportDataSource1.Value = this.ModelBindingSource;
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGAI.Report2.rdlc";
                        ModelTableAdapter.Fill(this.GAIDataSet.Model);

                        break;
                    }
            }
            this.reportViewer1.RefreshReport();  
        }
    }
}
