using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGAI.Service
{
    class CountryService
    {
        public static Country GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.Countries.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<Country> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.Countries.ToList();
            }
        }
    }
}
