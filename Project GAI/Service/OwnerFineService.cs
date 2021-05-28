using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class OwnerFineService
    {
        public static OwnerFine GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.OwnerFines.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<OwnerFine> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.OwnerFines.ToList();
            }
        }

        public static void Save(OwnerFine ownerfine)
        {

            using (var context = new GAIEntities())
            {
                try 
                {
                context.OwnerFines.Attach(ownerfine);

                context.Entry(ownerfine).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(OwnerFine ownerfine)
        {

            using (var context = new GAIEntities())
            {

                try
                {
                context.OwnerFines.Add(ownerfine);

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(OwnerFine ownerfine)
        {
            using (var context = new GAIEntities())
            {
                try{
                context.Entry(ownerfine).State = EntityState.Deleted;
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
                var ownerfine = GetById(id);
                context.Entry(ownerfine).State = EntityState.Deleted;
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
