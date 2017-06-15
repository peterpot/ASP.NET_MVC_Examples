using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DAL.EF;

namespace BLL { 
    public class BLLCareers : BLL
    {
        public BLLCareers()
        {
        }

        public BLLCareers(ISalaries_PRODEntities entity)
        {
            Entity = entity;
        }
        
        public string GetCareerNameById(string careerId)
        {
            var career = Entity.GetCareer_ByID(careerId).ToList();
            if (career != null && career.Count() > 0)
                return career.FirstOrDefault().CareerName;
            else
                return string.Empty;
        }

        public string GetCareerNameById_FromTable(string careerId)
        {
            var career = Entity.CAREERS.Where(f => f.CareerID == careerId);
            if (career != null && career.Count() > 0)
                return career.FirstOrDefault().CareerName ?? string.Empty;
            else
                return string.Empty;
        }

        public List<CAREER> GetCareersALL()
        {
            return Entity.CAREERS.ToList();
        }
    }
}
