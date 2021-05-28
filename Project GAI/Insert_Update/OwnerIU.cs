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
    public partial class OwnerIU : Form
    {
        public OwnerIU()
        {
            InitializeComponent();
        }
        public int Index; 
        public OwnerIU(int index, bool update)
            : this()
        {
            Index=index;
            if (update)
            {
                textBox1.Text = OwnerService.GetById(Convert.ToInt32(Index)).Name;
                textBox2.Text = OwnerService.GetById(Convert.ToInt32(Index)).MiddleName;
                textBox3.Text = OwnerService.GetById(Convert.ToInt32(Index)).LastName;
                textBox4.Text = OwnerService.GetById(Convert.ToInt32(Index)).Adres;
                button2.Visible = false;
                button1.Visible = true;
                Text = "Update";
            }
            else
            {
                button2.Visible = true;
                button1.Visible = false;
                Text = "Insert";
            }
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var OwnerList = new Owner();
            var Name = textBox1.Text;
            var MidlleName = textBox2.Text;
            var LastName = textBox3.Text;
            var Adres = textBox4.Text;

            OwnerList.Name = Name;
            OwnerList.MiddleName=MidlleName;
            OwnerList.LastName=LastName;
            OwnerList.Adres=Adres;
            OwnerService.Create(OwnerList);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var OwnerList = OwnerService.GetById(Index);
            var Name = textBox1.Text;
            var MidlleName = textBox2.Text;
            var LastName = textBox3.Text;
            var Adres = textBox4.Text;

            OwnerList.Name = Name;
            OwnerList.MiddleName = MidlleName;
            OwnerList.LastName = LastName;
            OwnerList.Adres = Adres;
            OwnerService.Save(OwnerList);
            Close();
        }

        private void OwnerIU_Load(object sender, EventArgs e)
        {

        }

        private void OwnerIU_Resize(object sender, EventArgs e)
        {
            button2.Left = button1.Left = panel1.Width / 2 - button1.Width / 2;
        }
    }
}
