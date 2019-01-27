using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworksales
{
   public class Customers
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Sale> Sales { get; set; }

        public Customers()
        {
            Sales = new List<Sale>();
        }
    }
}
