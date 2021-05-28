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
    public partial class CarIU : Form
    {
        public CarIU()
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
        public CarIU(int index, bool update)
            : this()
        {
            Index = index;
            dataGridView1.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            comboBox1.DataSource = CountryService.GetAll().OrderBy(p=>p.Name).Select(p => p.Name).ToList();
            comboBox2.DataSource = CountryService.GetAll().OrderBy(p => p.Name).Select(p => p.Name).ToList();
            dataGridView1.Columns[0].Visible = false;
            if (update)
            {
                int index1 = CarService.GetById(Index).ModelId;
                dataGridView1.CurrentCell = dataGridView1.Rows[DGVindex(dataGridView1,index1)].Cells[1];
                comboBox1.SelectedItem = CountryService.GetById(CarService.GetById(index).CountryId).Name;
                comboBox2.SelectedItem = CountryService.GetById(CarService.GetById(index).PlaceRegId).Name;
                textBox1.Text = CarService.GetById(Index).NumberEngine.ToString();
                textBox2.Text = CarService.GetById(Index).NumberChassis.ToString();
                textBox3.Text = CarService.GetById(Index).NumberBody.ToString();
                button2.Visible = false;
                button1.Visible = true;
                Text = "Update";
            }
            else
            {
                dataGridView1.CurrentCell = null;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                button2.Visible = true;
                button1.Visible = false;
                Text = "Insert";
            }
            comboBox1.Refresh();
            comboBox2.Refresh();
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;

        }
        private void CarIU_Load(object sender, EventArgs e)
        {

        }

        private void CarIU_Resize(object sender, EventArgs e)
        {
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CarList = new Car();
            var ModelId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var CountryId = CountryService.GetAll().FirstOrDefault(x => x.Name == comboBox1.Text).Id; 
            var PlaceRegId = CountryService.GetAll().FirstOrDefault(x => x.Name == comboBox2.Text).Id;
            var NumberBody = Convert.ToInt32(textBox3.Text);
            var NumberChassis = Convert.ToInt32(textBox2.Text);
            var NumberEngine = Convert.ToInt32(textBox1.Text);
            CarList.ModelId=ModelId;
            CarList.CountryId=CountryId;
            CarList.PlaceRegId=PlaceRegId;
            CarList.NumberBody=NumberBody;
            CarList.NumberChassis=NumberChassis;
            CarList.NumberEngine=NumberEngine;
            CarService.Create(CarList);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CarList = CarService.GetById(Convert.ToInt32(Index));
            var ModelId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var CountryId = CountryService.GetAll().FirstOrDefault(x => x.Name == comboBox1.Text).Id; 
            var PlaceRegId = CountryService.GetAll().FirstOrDefault(x => x.Name == comboBox2.Text).Id;
            var NumberBody = Convert.ToInt32(textBox3.Text);
            var NumberChassis = Convert.ToInt32(textBox2.Text);
            var NumberEngine = Convert.ToInt32(textBox1.Text);
            CarList.ModelId = ModelId;
            CarList.CountryId = CountryId;
            CarList.PlaceRegId = PlaceRegId;
            CarList.NumberBody = NumberBody;
            CarList.NumberChassis = NumberChassis;
            CarList.NumberEngine = NumberEngine;
            CarService.Save(CarList);
            Close();
        }

    }
}
