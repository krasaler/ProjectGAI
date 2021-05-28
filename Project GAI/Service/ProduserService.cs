using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProjectGAI.Service
{
    class ProduserService
    {
        public static Produser GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Produsers.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<Produser> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Produsers.ToList();
            }
        }
        public static void Save(Produser produser)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                context.Produsers.Attach(produser);

                context.Entry(produser).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(Produser produser)
        {

            using (var context = new GAIEntities())
            {
                try{
                context.Produsers.Add(produser);

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(Produser produser)
        {
            using (var context = new GAIEntities())
            {
                try{
                context.Entry(produser).State = EntityState.Deleted;
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
                var produser = GetById(id);
                context.Entry(produser).State = EntityState.Deleted;
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
