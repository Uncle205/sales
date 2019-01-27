using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworksales
{
   public class Sale
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdDealer { get; set; }
        public int Summ { get; set; }
        public DateTime Date { get; set; }
    }
}
