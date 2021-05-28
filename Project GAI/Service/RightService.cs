using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class RightService
    {
        public static Right GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Rights.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<Right> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Rights.ToList();
            }
        }

        public static void Save(Right right)
        {

            using (var context = new GAIEntities())
            {

                try
                {
                context.Rights.Attach(right);

                context.Entry(right).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(Right right)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                context.Rights.Add(right);

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public static void Delete(Right right)
        {
            using (var context = new GAIEntities())
            {
                try{
                context.Entry(right).State = EntityState.Deleted;
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
                try{
                var right = GetById(id);
                context.Entry(right).State = EntityState.Deleted;
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
