using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectGAI.Service;
using ProjectGAI.ViewModels;
using ProjectGAI.ViewModelHelper;

namespace ProjectGAI
{
    public partial class RightIU : Form
    {
        public RightIU()
        {
            InitializeComponent();
        }
        public int DGVindex(DataGridView DGV,int index)
        {
            for (int i = 0; i < DGV.RowCount; i++)
            {
                if (Convert.ToInt32(DGV[0, i].Value.ToString()) == index)
                    return i;
            }
            return -1;
        }
        public int Index;
        public RightIU(int index, bool update)
            : this()
        {
            Index = index;
            dataGridView1.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
            dataGridView2.DataSource = RightsTypeService.GetAll(); 
            if (update)
            {
                int index1 = RightService.GetById(Index).OwnerId;
                int index2 = RightService.GetById(Index).RightTypeId;
             //   dataGridView1.Columns[0].Visible = false;
                dataGridView1.CurrentCell = dataGridView1.Rows[DGVindex(dataGridView1, index1)].Cells[1];
                dataGridView2.CurrentCell = dataGridView2.Rows[DGVindex(dataGridView2,index2)].Cells[1];
                monthCalendar1.SetDate(RightService.GetById(Index).Data);
                button2.Visible = false;
                button1.Visible = true;
                Text = "Update";
            }
            else
            {
                dataGridView1.Rows[0].Visible = false;
                dataGridView1.CurrentCell = null;
                dataGridView2.CurrentCell = null;
                button2.Visible = true;
                button1.Visible = false;
                Text = "Insert";
            }
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }

        private void RightIU_Load(object sender, EventArgs e)
        {

        }

        private void RightIU_Resize(object sender, EventArgs e)
        {
            button2.Left=button1.Left = panel1.Width / 2 - button1.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var RightList =  new Right();
            var OwnerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var RightTypesID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            RightList.OwnerId = OwnerID;
            RightList.RightTypeId = RightTypesID;
            RightList.Data = monthCalendar1.SelectionRange.Start;
            RightService.Create(RightList);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RightList = RightService.GetById(Index);
            var OwnerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var RightTypesID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            RightList.OwnerId = OwnerID;
            RightList.RightTypeId = RightTypesID;
            RightList.Data = monthCalendar1.SelectionRange.Start;

            RightService.Save(RightList);
            Close();
        }
    }
}
