using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectGAI.Service
{
    class BodyTypeClassificationService
    {
        public static BodyTypeClassification GetById(int id)
        {
            using (var context = new GAIEntities())
            {
                return context.BodyTypeClassifications.FirstOrDefault(s => s.Id == id);
            }
        }
        public static List<BodyTypeClassification> GetAll()
        {
            using (var context = new GAIEntities())
            {
                return context.BodyTypeClassifications.ToList();
            }
        }
    }
}
