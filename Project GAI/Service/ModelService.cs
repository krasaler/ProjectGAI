using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class ModelService
    {
        public static Model GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Models.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<Model> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Models.ToList();
            }
        }

        public static void Save(Model model)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                context.Models.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(Model model)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                context.Models.Add(model);

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(Model model)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteById(int id)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                var model = GetById(id);
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
