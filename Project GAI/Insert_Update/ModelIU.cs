using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectGAI.Service;
using ProjectGAI.ViewModelHelper;

namespace ProjectGAI
{
    public partial class ModelIU : Form
    {
        public ModelIU()
        {
            InitializeComponent();
        }
        public int Index;
        public ModelIU(int index, bool update)
            : this()
        {
            Index= index;
            var producerNames = ProduserService.GetAll().OrderBy(p => p.Name).Select(p => p.Name).ToList();
            var BodyTypesName = BodyTypeService.GetAll().OrderBy(p => p.Name).Select(p => p.Name).ToList();
            var ModelsNames = ModelService.GetAll().OrderBy(p => p.Name).Select(p => p.Name).ToList(); 

            comboBox1.DataSource = producerNames;
            comboBox2.DataSource = ModelsNames;
            comboBox3.DataSource = BodyTypesName;
            if (update)
            {
                button1.Visible = false;
                button2.Visible = true;
                Text = "Update";
                comboBox1.SelectedItem = ProduserService.GetById(ModelService.GetById(Index).ProduserId).Name;
                comboBox2.SelectedItem = ModelService.GetById(Index).Name;
                comboBox3.SelectedItem = BodyTypeService.GetById(ModelService.GetById(Index).BodyTypesId).Name;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                button1.Visible = true;
                button2.Visible = false;
                Text = "Insert";
            }
            comboBox1.Refresh();
            comboBox2.Refresh();
            comboBox3.Refresh();
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }

        private void Form2Load(object sender, EventArgs e)
        {

        }

        private void Button1Click(object sender, EventArgs e)
        {
            var ModelList = new Model();
            var producerID = ProduserService.GetAll().FirstOrDefault(x => x.Name == comboBox1.Text).Id;
            var BodyTypesID = BodyTypeService.GetAll().FirstOrDefault(x => x.Name == comboBox3.Text).Id;
            ModelList.ProduserId=producerID;
            ModelList.BodyTypesId=BodyTypesID;
            ModelList.Name=comboBox2.Text;

            ModelService.Create(ModelList);
            Close();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var ModelList = ModelService.GetById(Index);
            var producerID = ProduserService.GetAll().FirstOrDefault(x => x.Name == comboBox1.Text).Id;
            var BodyTypesID = BodyTypeService.GetAll().FirstOrDefault(x => x.Name == comboBox3.Text).Id;
            ModelList.ProduserId = producerID;
            ModelList.BodyTypesId = BodyTypesID;
            ModelList.Name = comboBox2.Text;

            ModelService.Save(ModelList);
            Close();

        }

        private void ModelIuResize(object sender, EventArgs e)
        {

            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {         
                int ProduserID = ProduserService.GetAll().FirstOrDefault(p => p.Name == comboBox1.Text).Id;
                var PL = ModelService.GetAll().Where(x => x.ProduserId == ProduserID).Select(x=>x.Name).ToList();
                comboBox2.DataSource = PL;
            }
        }

    }
}
