namespace ProjectGAI
{
    partial class Reports
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
            this.CaroOwnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GAIDataSet = new ProjectGAI.GAIDataSet();
            this.View3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RightTableAdapter = new ProjectGAI.GAIDataSetTableAdapters.RightTableAdapter();
            this.CaroOwnersTableAdapter = new ProjectGAI.GAIDataSetTableAdapters.CaroOwnersTableAdapter();
            this.OwnerFineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerFineTableAdapter = new ProjectGAI.GAIDataSetTableAdapters.OwnerFineTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModelTableAdapter = new ProjectGAI.GAIDataSetTableAdapters.ModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CaroOwnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GAIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerFineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CaroOwnersBindingSource
            // 
            this.CaroOwnersBindingSource.DataMember = "CaroOwners";
            this.CaroOwnersBindingSource.DataSource = this.GAIDataSet;
            // 
            // GAIDataSet
            // 
            this.GAIDataSet.DataSetName = "GAIDataSet";
            this.GAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RightBindingSource
            // 
            this.RightBindingSource.DataMember = "Right";
            this.RightBindingSource.DataSource = this.GAIDataSet;
            // 
            // RightTableAdapter
            // 
            this.RightTableAdapter.ClearBeforeFill = true;
            // 
            // CaroOwnersTableAdapter
            // 
            this.CaroOwnersTableAdapter.ClearBeforeFill = true;
            // 
            // OwnerFineBindingSource
            // 
            this.OwnerFineBindingSource.DataMember = "OwnerFine";
            this.OwnerFineBindingSource.DataSource = this.GAIDataSet;
            // 
            // OwnerFineTableAdapter
            // 
            this.OwnerFineTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 49;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGAI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(571, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // ModelBindingSource
            // 
            this.ModelBindingSource.DataMember = "Model";
            this.ModelBindingSource.DataSource = this.GAIDataSet;
            // 
            // ModelTableAdapter
            // 
            this.ModelTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reports";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaroOwnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GAIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerFineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource View3BindingSource;
        private GAIDataSet GAIDataSet;
        private System.Windows.Forms.BindingSource RightBindingSource;
        private GAIDataSetTableAdapters.RightTableAdapter RightTableAdapter;
        private System.Windows.Forms.BindingSource CaroOwnersBindingSource;
        private GAIDataSetTableAdapters.CaroOwnersTableAdapter CaroOwnersTableAdapter;
        private System.Windows.Forms.BindingSource OwnerFineBindingSource;
        private GAIDataSetTableAdapters.OwnerFineTableAdapter OwnerFineTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ModelBindingSource;
        private GAIDataSetTableAdapters.ModelTableAdapter ModelTableAdapter;
    }
}