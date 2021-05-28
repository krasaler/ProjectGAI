using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectGAI.Service
{
    class FinesTypeService
    {
        public static FinesType GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.FinesTypes.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<FinesType> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.FinesTypes.ToList();
            }
        }
        public static void Save(FinesType finestype)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                    context.FinesTypes.Attach(finestype);

                    context.Entry(finestype).State = EntityState.Modified;

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }


        public static void Create(FinesType finestype)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                    context.FinesTypes.Add(finestype);

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(FinesType finestype)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                    context.Entry(finestype).State = EntityState.Deleted;
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
                    var finestype = GetById(id);
                    context.Entry(finestype).State = EntityState.Deleted;
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
