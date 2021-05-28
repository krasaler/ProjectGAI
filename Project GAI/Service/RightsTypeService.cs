using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGAI.Service
{
    class RightsTypeService
    {
        public static RightsType GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.RightsTypes.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<RightsType> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.RightsTypes.ToList();
            }
        }
    }
}
