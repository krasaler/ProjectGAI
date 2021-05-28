using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGAI.Service
{
    class BodyTypeService
    {
        public static BodyType GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.BodyTypes.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<BodyType> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.BodyTypes.ToList();
            }
        }

    }
}
