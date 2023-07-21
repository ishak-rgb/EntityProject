using Entities.Abstrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:Ientities
    {
        private string productName;

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get => productName; set => productName = value; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
