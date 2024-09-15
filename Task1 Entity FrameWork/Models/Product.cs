using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Entity_FrameWork.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
       // public string Sales { get; set; }
        public Sale sale { get; set; }
        public int SaleId { get; set; }
        public string Description { get; set; }


    }
}
