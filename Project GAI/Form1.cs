using System;
using System.Linq;
using System.Windows.Forms;
using ProjectGAI.Service;
using ProjectGAI.ViewModelHelper;
using System.Diagnostics;

namespace ProjectGAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            comboBox7.DataSource = BodyTypeViewModelHelper.PopulateBodyTypeViewModelList(BodyTypeService.GetAll()).Select(p => p.Name).ToList();
            comboBox5.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll()).Select(p => p.Name).ToList();
            comboBox9.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox6.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox8.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox11.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            BodyTypeClassificationGridView.DataSource = BodyTypeClassificationService.GetAll();
            BodyTypeGridView.DataSource = BodyTypeViewModelHelper.PopulateBodyTypeViewModelList(BodyTypeService.GetAll());
            RightsTypeGridView.DataSource = RightsTypeService.GetAll();
            RightGridView.DataSource = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
            ProduserGridView.DataSource = ProduserService.GetAll();
            OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
            OwnerGridView.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
            FinesTypeGridView.DataSource = FinesTypeService.GetAll();
            CountryGridView.DataSource = CountryService.GetAll();
            CarOwnerGridView.DataSource = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
            CarGridView.DataSource = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
            comboBox1.DataSource = RightsTypeService.GetAll().Select(p => p.Name).ToList();
            comboBox4.DataSource = comboBox2.DataSource = ProduserService.GetAll().Select(p => p.Name).ToList();
            comboBox3.DataSource = FinesTypeService.GetAll().Select(p=>p.Name).ToList();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            ModelIU form2 = new ModelIU(0,false);
            form2.ShowDialog();

            ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            comboBox5.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll()).Select(p => p.Name).ToList();

          
        }

        private void Button3Click(object sender, EventArgs e)
        {
            try
            {
                ModelService.DeleteById(Convert.ToInt32(ModelGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var modelList = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
                ModelGridView.DataSource = modelList;
                ModelGridView.Refresh();
                ProduserGridView.DataSource = ProduserService.GetAll();
                ProduserGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button6Click(object sender, EventArgs e)
        {
            try
            {
                RightService.DeleteById(Convert.ToInt32(RightGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var rightList = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
                RightGridView.DataSource = rightList;
                RightGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button9Click(object sender, EventArgs e)
        {
            try
            {
                OwnerFineService.DeleteById(Convert.ToInt32(OwnerFineGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var ownerfineList = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
                OwnerFineGridView.DataSource = ownerfineList;
                OwnerFineGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button10Click(object sender, EventArgs e)
        {
            try
            {
                OwnerService.DeleteById(Convert.ToInt32(OwnerGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var ownerList = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
                OwnerGridView.DataSource = ownerList;
                OwnerGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button13Click(object sender, EventArgs e)
        {
            try
            {
                CarOwnerService.DeleteById(Convert.ToInt32(CarOwnerGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var ownerList = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
                CarOwnerGridView.DataSource = ownerList;
                CarOwnerGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button16Click(object sender, EventArgs e)
        {
            try
            {
                CarService.DeleteById(Convert.ToInt32(CarGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var ownerList = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
                CarGridView.DataSource = ownerList;
                CarGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            ModelIU form2 = new ModelIU(Convert.ToInt32(ModelGridView.CurrentRow.Cells["ID"].Value.ToString()), true);
            form2.ShowDialog();

            ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            comboBox5.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll()).Select(p => p.Name).ToList();

        }

        private void Button4Click(object sender, EventArgs e)
        {
            RightIU rightIU = new RightIU(0, false);
            rightIU.ShowDialog();

            RightGridView.DataSource = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
        }

        private void Button5Click(object sender, EventArgs e)
        {
            RightIU rightIU = new RightIU((int)RightGridView.CurrentRow.Cells["Id"].Value, true);
            rightIU.ShowDialog();

            RightGridView.DataSource = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
        }

        private void Button7Click(object sender, EventArgs e)
        {
            OwnerFineIU form2 = new OwnerFineIU(0, false);
            form2.ShowDialog();

            OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
        }

        private void Button8Click(object sender, EventArgs e)
        {
            OwnerFineIU form2 = new OwnerFineIU((int)OwnerFineGridView.CurrentRow.Cells["Id"].Value, true);
            form2.ShowDialog();

            OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
        }

        private void Button12Click(object sender, EventArgs e)
        {
            OwnerIU form2 = new OwnerIU(0, false);
            form2.ShowDialog();

            OwnerGridView.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OwnerIU form2 = new OwnerIU(Convert.ToInt32(OwnerGridView.CurrentRow.Cells["Id"].Value.ToString()), true);
            form2.ShowDialog();

            OwnerGridView.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
          

            
        }

        private void Button15Click(object sender, EventArgs e)
        {
            CarOwnerIU form2 = new CarOwnerIU(0, false);
            form2.ShowDialog();

            CarOwnerGridView.DataSource = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
        }

        private void Button14Click(object sender, EventArgs e)
        {
            CarOwnerIU form2 = new CarOwnerIU((int)CarOwnerGridView.CurrentRow.Cells["Id"].Value, true);
            form2.ShowDialog();

            CarOwnerGridView.DataSource = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
        }

        private void Button18Click(object sender, EventArgs e)
        {
            CarIU form2 = new CarIU(0, false);
            form2.ShowDialog();

            CarGridView.DataSource = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
        }

        private void Button17Click(object sender, EventArgs e)
        {
            CarIU form2 = new CarIU((int)CarGridView.CurrentRow.Cells["Id"].Value, true);
            form2.ShowDialog();

            CarGridView.DataSource = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
        }

        private void ProduserGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button19Click(object sender, EventArgs e)
        {
            var produserList = new Produser();
            var producerName = Microsoft.VisualBasic.Interaction.InputBox("Введлите название изготовителя","Ввод изготовителя","",100,100);
            if (producerName!="")
            {
                produserList.Name = producerName;
                ProduserService.Create(produserList);
                ProduserGridView.DataSource = ProduserService.GetAll();
                ProduserGridView.Refresh();
                ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
                ModelGridView.Refresh();
                comboBox4.DataSource = comboBox2.DataSource = ProduserService.GetAll().Select(p => p.Name).ToList();
            }
        }

        private void Button21Click(object sender, EventArgs e)
        {
            try
            {
                ProduserService.DeleteById(Convert.ToInt32(ProduserGridView.CurrentRow.Cells["Id"].Value.ToString()));
                var produserList = ProduserService.GetAll();
                ProduserGridView.DataSource = produserList;
                ProduserGridView.Refresh();
                ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
                ModelGridView.Refresh();
                comboBox4.DataSource = comboBox2.DataSource = ProduserService.GetAll().Select(p => p.Name).ToList();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button20Click(object sender, EventArgs e)
        {
            var produserList = ProduserService.GetById((int)ProduserGridView.CurrentRow.Cells["Id"].Value);
            var producerName = Microsoft.VisualBasic.Interaction.InputBox("Введлите название изготовителя", "Ввод изготовителя", ProduserService.GetById((int) ProduserGridView.CurrentRow.Cells["Id"].Value).Name, 100, 100);
            produserList.Name = producerName;
            ProduserService.Save(produserList);
            ProduserGridView.DataSource = ProduserService.GetAll();
            ProduserGridView.Refresh();
            ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            ModelGridView.Refresh();
        }

        private void Button22Click(object sender, EventArgs e)
        {
          var finesTypeList = new FinesType();
            var finesTypeName = Microsoft.VisualBasic.Interaction.InputBox("Введлите название штрафа","Ввод штрафа","",100,100);
            if (finesTypeName != "")
            {
                finesTypeList.Name = finesTypeName;
                FinesTypeService.Create(finesTypeList);
                FinesTypeGridView.DataSource = FinesTypeService.GetAll();
                FinesTypeGridView.Refresh();
                OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
                OwnerFineGridView.Refresh();
                comboBox3.DataSource = FinesTypeService.GetAll().Select(p => p.Name).ToList();
            }
        }

        private void Button24Click(object sender, EventArgs e)
        {
            try
            {
                FinesTypeService.DeleteById(Convert.ToInt32(FinesTypeGridView.CurrentRow.Cells[0].Value.ToString()));
                var finesTypeList = FinesTypeService.GetAll();
                FinesTypeGridView.DataSource = finesTypeList;
                FinesTypeGridView.Refresh();
                OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
                OwnerFineGridView.Refresh();
            }
            catch (Exception t)
            {
                MessageBox.Show("Удалить нельзя\n" + t.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button23Click(object sender, EventArgs e)
        {
            var finesTypeList = FinesTypeService.GetById((int)FinesTypeGridView.CurrentRow.Cells[0].Value);
            var finesTypeName = Microsoft.VisualBasic.Interaction.InputBox("Введлите название штрафа", "Ввод штрафа", finesTypeList.Name, 100, 100);
            finesTypeList.Name = finesTypeName;
            FinesTypeService.Save(finesTypeList);
            FinesTypeGridView.DataSource = FinesTypeService.GetAll();
            FinesTypeGridView.Refresh();
            OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
            OwnerFineGridView.Refresh();
            comboBox3.DataSource = FinesTypeService.GetAll().Select(p => p.Name).ToList();
        }

        private void Button26Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" | comboBox2.Text != ""|textBox8.Text != "" |textBox7.Text != "" )
            {

                var ModelList = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
                if (textBox1.Text != "")
                {
                    ModelList = ModelList.Where(p => p.Name.IndexOf(textBox1.Text) >= 0).ToList();
                }
                if (textBox8.Text != "")
                {
                    ModelList = ModelList.Where(p => p.BodyTypesName.IndexOf(textBox8.Text) >= 0).ToList();
                }
                if (textBox7.Text != "")
                {
                    ModelList = ModelList.Where(p => p.BodyTypeClassificationsName.IndexOf(textBox7.Text) >= 0).ToList();
                }
                if (comboBox2.Text != "")
                {
                    ModelList = ModelList.Where(p => p.ProducerName.IndexOf(comboBox2.Text) >= 0).ToList();
                }
                ModelGridView.DataSource = ModelList;
            }
            else
                ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            ModelGridView.Refresh();
        }

        private void Button27Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                ProduserGridView.DataSource = ProduserService.GetAll().Where(p => p.Name.IndexOf(textBox3.Text) >= 0).ToList();
            else
                ProduserGridView.DataSource = ProduserService.GetAll();
            ProduserGridView.Refresh();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="" | textBox4.Text!="" | textBox5.Text!="" | textBox6.Text!=""|comboBox1.Text!="")
            {
               var RightList =
                    RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
                if (textBox4.Text!="")
                    RightList=RightList.Where(p=>p.Name.IndexOf(textBox4.Text)>=0).ToList();
                if (textBox5.Text!="")
                    RightList=RightList.Where(p=>p.MiddleName.IndexOf(textBox5.Text)>=0).ToList();
                if (textBox6.Text!="")
                    RightList=RightList.Where(p=>p.LastName.IndexOf(textBox6.Text)>=0).ToList();
                if (textBox2.Text!="")
                    RightList=RightList.Where(p=>p.Address.IndexOf(textBox2.Text)>=0).ToList();
                if (comboBox1.Text != "")
                    RightList = RightList.Where(p => p.RightTypeName.IndexOf(comboBox1.Text) >= 0).ToList();
                RightGridView.DataSource = RightList;
            }
            else
                RightGridView.DataSource = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());;
            RightGridView.Refresh();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "" | textBox10.Text != "" | textBox9.Text != "" | textBox12.Text != "")
            {
                var OwnerList =
                      OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
                if (textBox11.Text != "")
                    OwnerList = OwnerList.Where(p => p.Name.IndexOf(textBox11.Text) >= 0).ToList();
                if (textBox10.Text != "")
                    OwnerList = OwnerList.Where(p => p.MiddleName.IndexOf(textBox10.Text) >= 0).ToList();
                if (textBox9.Text != "")
                    OwnerList = OwnerList.Where(p => p.LastName.IndexOf(textBox9.Text) >= 0).ToList();
                if (textBox12.Text != "")
                    OwnerList = OwnerList.Where(p => p.Adres.IndexOf(textBox12.Text) >= 0).ToList();
                OwnerGridView.DataSource = OwnerList;
            }
            else
                OwnerGridView.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
            OwnerGridView.Refresh();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "" | textBox15.Text != "" | textBox14.Text != "" | textBox13.Text != "" | comboBox3.Text!="")
            {
                var ownerFineList =OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
                if (textBox16.Text != "")
                    ownerFineList = ownerFineList.Where(p => p.Name.IndexOf(textBox16.Text) >= 0).ToList();
                if (textBox15.Text != "")
                    ownerFineList = ownerFineList.Where(p => p.MiddleName.IndexOf(textBox15.Text) >= 0).ToList();
                if (textBox14.Text != "")
                    ownerFineList = ownerFineList.Where(p => p.LastName.IndexOf(textBox14.Text) >= 0).ToList();
                if (textBox13.Text != "")
                    ownerFineList = ownerFineList.Where(p => p.Address.IndexOf(textBox13.Text) >= 0).ToList();
                if (comboBox3.Text != "")
                    ownerFineList = ownerFineList.Where(p => p.FineTypeName.IndexOf(comboBox3.Text) >= 0).ToList();
                OwnerFineGridView.DataSource = ownerFineList;
            }
            else
                OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
            OwnerFineGridView.Refresh();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                var FineList = FinesTypeService.GetAll();
                FinesTypeGridView.DataSource = FineList.Where(p=>p.Name.IndexOf(textBox17.Text)>=0).ToList();
            }
            else
                FinesTypeGridView.DataSource = FinesTypeService.GetAll();
            FinesTypeGridView.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox19.Text != "" | textBox20.Text != "" | textBox21.Text != "" | comboBox4.Text != "" 
                | comboBox5.Text != "" | comboBox6.Text != "" | comboBox7.Text != "" | comboBox9.Text != "")
            {
                var carList = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
                if (textBox19.Text != "")
                    carList = carList.Where(p => p.NumberBody.ToString().IndexOf(textBox19.Text)>=0).ToList();
                if (textBox20.Text != "")
                    carList = carList.Where(p => p.NumberEngine.ToString().IndexOf(textBox20.Text)>=0).ToList();
                if (textBox21.Text != "")
                    carList = carList.Where(p => p.NumberChassis.ToString().IndexOf(textBox21.Text) >= 0).ToList();
                if (comboBox4.Text != "")
                    carList = carList.Where(p => p.ProducerName.IndexOf(comboBox4.Text) >= 0).ToList();
                if (comboBox5.Text != "")
                    carList = carList.Where(p => p.ModelName.IndexOf(comboBox5.Text) >= 0).ToList();
                if (comboBox6.Text != "")
                    carList = carList.Where(p => p.CountryName.IndexOf(comboBox6.Text) >= 0).ToList();
                if (comboBox7.Text != "")
                    carList = carList.Where(p => p.BodyTypesName.IndexOf(comboBox7.Text) >= 0).ToList();
                if (comboBox9.Text != "")
                    carList = carList.Where(p => p.PlaceRegName.IndexOf(comboBox9.Text) >= 0).ToList();
                CarGridView.DataSource = carList;
            }
            else
                CarGridView.DataSource = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
            CarGridView.Refresh();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox22.Text != "" |textBox23.Text != "" |textBox24.Text != "" |textBox25.Text != "" |textBox26.Text != "" |
                textBox27.Text != "" | comboBox8.Text != "" | comboBox11.Text != "" | textBox18.Text != "" | textBox28.Text != "")
            {
                var carList = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
                if (textBox22.Text != "")
                    carList = carList.Where(p => p.NumberEngine.ToString().IndexOf(textBox22.Text) >= 0).ToList();
                if (textBox23.Text != "")
                    carList = carList.Where(p => p.NumberBody.ToString().IndexOf(textBox23.Text) >= 0).ToList();
                if (textBox24.Text != "")
                    carList = carList.Where(p => p.Adres.IndexOf(textBox24.Text) >= 0).ToList();
                if (textBox25.Text != "")
                    carList = carList.Where(p => p.LastName.IndexOf(textBox25.Text) >= 0).ToList();
                if (textBox26.Text != "")
                    carList = carList.Where(p => p.MiddleName.IndexOf(textBox26.Text) >= 0).ToList();
                if (textBox27.Text != "")
                    carList = carList.Where(p => p.Name.IndexOf(textBox27.Text) >= 0).ToList();
                if (comboBox8.Text != "")
                    carList = carList.Where(p => p.PlaceRegName.IndexOf(comboBox8.Text) >= 0).ToList();
                if (comboBox11.Text != "")
                    carList = carList.Where(p => p.CountryName.IndexOf(comboBox11.Text) >= 0).ToList();
                if (textBox28.Text != "")
                    carList = carList.Where(p => p.ModelName.IndexOf(textBox28.Text) >= 0).ToList();
                CarOwnerGridView.DataSource = carList;
            }
            else
                CarOwnerGridView.DataSource = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
            CarOwnerGridView.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void вывестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox7.DataSource = BodyTypeViewModelHelper.PopulateBodyTypeViewModelList(BodyTypeService.GetAll()).Select(p => p.Name).ToList();
            comboBox5.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll()).Select(p => p.Name).ToList();
            comboBox9.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox6.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox8.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            comboBox11.DataSource = CountryService.GetAll().Select(p => p.Name).ToList();
            ModelGridView.DataSource = ModelViewModelHelper.PopulateModelViewModelList(ModelService.GetAll());
            BodyTypeClassificationGridView.DataSource = BodyTypeClassificationService.GetAll();
            BodyTypeGridView.DataSource = BodyTypeViewModelHelper.PopulateBodyTypeViewModelList(BodyTypeService.GetAll());
            RightsTypeGridView.DataSource = RightsTypeService.GetAll();
            RightGridView.DataSource = RightViewModelHelper.PopulateRightViewModelList(RightService.GetAll());
            ProduserGridView.DataSource = ProduserService.GetAll();
            OwnerFineGridView.DataSource = OwnerFineViewModelHelper.PopulateOwnerFineViewModelList(OwnerFineService.GetAll());
            OwnerGridView.DataSource = OwnerViewModelHelper.PopulateOwnerViewModelList(OwnerService.GetAll());
            FinesTypeGridView.DataSource = FinesTypeService.GetAll();
            CountryGridView.DataSource = CountryService.GetAll();
            CarOwnerGridView.DataSource = CarOwnerViewModelHelper.PopulateCarOwnerViewModelList(CarOwnerService.GetAll());
            CarGridView.DataSource = CarViewModelHelper.PopulateCarViewModelList(CarService.GetAll());
            comboBox1.DataSource = RightsTypeService.GetAll().Select(p => p.Name).ToList();
            comboBox4.DataSource = comboBox2.DataSource = ProduserService.GetAll().Select(p => p.Name).ToList();
            comboBox3.DataSource = FinesTypeService.GetAll().Select(p=>p.Name).ToList();
        }

        private void carOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(1);
            report.ShowDialog();
        }

        private void ownerFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(2);
            report.ShowDialog();
        }

        private void rightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(3);
            report.ShowDialog();
        }

        private void modelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(4);
            report.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("help.docx");
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        


    }
}
