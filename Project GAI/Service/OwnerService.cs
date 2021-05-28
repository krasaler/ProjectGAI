using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class OwnerService
    {
        public static Owner GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Owners.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<Owner> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Owners.ToList();
            }
        }

        public static void Save(Owner owner)
        {

            using (var context = new GAIEntities())
            {
                try{
                context.Owners.Attach(owner);

                context.Entry(owner).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(Owner owner)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                    context.Owners.Add(owner);

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(Owner owner)
        {
            using (var context = new GAIEntities())
            {
                try{
                context.Entry(owner).State = EntityState.Deleted;
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
                var owner = GetById(id);
                context.Entry(owner).State = EntityState.Deleted;
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
