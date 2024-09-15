using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Entity_FrameWork.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        //public string sales { get; set; }
        public Sale sale { get; set; }
        public int SaleId { get; set; }

    }
}
