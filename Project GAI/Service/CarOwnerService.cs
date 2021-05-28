using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class CarOwnerService
    {
        public static CarOwner GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.CarOwner.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<CarOwner> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.CarOwner.ToList();
            }
        }

        public static void Save(CarOwner carowner)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                context.CarOwner.Attach(carowner);

                context.Entry(carowner).State = EntityState.Modified;

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static void Create(CarOwner carowner)
        {

            using (var context = new GAIEntities())
            {

                try
                {
                context.CarOwner.Add(carowner);

                context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(CarOwner carowner)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                    context.Entry(carowner).State = EntityState.Deleted;
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
                var car = GetById(id);
                context.Entry(car).State = EntityState.Deleted;
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
