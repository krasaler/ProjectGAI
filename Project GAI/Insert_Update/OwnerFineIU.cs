using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectGAI.ViewModelHelper;
using ProjectGAI.Service;

namespace ProjectGAI
{
    public partial class OwnerFineIU : Form
    {
        public OwnerFineIU()
        {
            InitializeComponent();
        }
        public int Index; 
        public int DGVindex(DataGridView DGV,int index)
        {
            for (int i = 0; i < DGV.RowCount; i++)
            {
                if (Convert.ToInt32(DGV[0, i].Value.ToString()) == index)
                    return i;
            }
            return -1;
        }
        public OwnerFineIU(int index, bool update)
            : this()
        {
            Index = index;
            dataGridView1.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
            dataGridView2.DataSource = FinesTypeService.GetAll();
            dataGridView1.Columns[0].Visible = false;
            if (update)
            {
                int index1 = OwnerFineService.GetById(Index).OwnerId;
                int index2 = OwnerFineService.GetById(Index).FineTypeId;

                dataGridView1.CurrentCell = dataGridView1.Rows[DGVindex(dataGridView1, index1)].Cells[1];
                dataGridView2.CurrentCell = dataGridView2.Rows[DGVindex(dataGridView2, index2)].Cells[1];
                button2.Visible = false;
                button1.Visible = true;
                Text = "Update";
            }
            else
            {
                dataGridView1.CurrentCell = null;
                dataGridView2.CurrentCell = null;
                button2.Visible = true;
                button1.Visible = false;
                Text = "Insert";
            }
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var OwnerFineList =  new OwnerFine();
            var OwnerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var FinesTypeID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            OwnerFineList.OwnerId = OwnerID;
            OwnerFineList.FineTypeId = FinesTypeID;
            OwnerFineService.Create(OwnerFineList);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var OwnerFineList = OwnerFineService.GetById(Index);
            var OwnerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var FinesTypeID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            OwnerFineList.OwnerId = OwnerID;
            OwnerFineList.FineTypeId = FinesTypeID;
            OwnerFineService.Save(OwnerFineList);
            Close();
        }

        private void OwnerFineIU_Load(object sender, EventArgs e)
        {

        }

        private void OwnerFineIU_Resize(object sender, EventArgs e)
        {
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }
    }
}
