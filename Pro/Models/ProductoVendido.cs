using System;
using System.Collections.Generic;
using System.Text;

namespace Pro.Models
{
    class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
    }
}
