using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Entity_FrameWork.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public List<Customer> customers { get; set; }
        public List<Product> products { get; set; }
        public List<Store> stores { get; set; }
        public string Data { get; set; }








    }
}
