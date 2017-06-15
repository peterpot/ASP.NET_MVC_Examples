using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DAL.EF;

namespace BLL
{
    public class BLL
    {
        protected ISalaries_PRODEntities Entity;

        public BLL()
        {
            Entity = new Salaries_PRODEntities();
        }
    }
}
