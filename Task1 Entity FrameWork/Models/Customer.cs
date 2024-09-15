using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Entity_FrameWork.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }
        //public string Sales { get; set; }
        public Sale sale { get; set; }
        public int SaleId { get; set; }




    }
}
