using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectGAI.Service
{
    class CarService
    {
        public static Car GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Cars.FirstOrDefault(s => s.Id == id);
            }
        }

        public static List<Car> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Cars.ToList();
            }
        }

        public static void Save(Car car)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                    context.Cars.Attach(car);

                    context.Entry(car).State = EntityState.Modified;

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }


        public static void Create(Car car)
        {

            using (var context = new GAIEntities())
            {
                try
                {
                    context.Cars.Add(car);

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Операцимя невозможна", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public static void Delete(Car car)
        {
            using (var context = new GAIEntities())
            {
                try
                {
                context.Entry(car).State = EntityState.Deleted;
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
