using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIt_Maui.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public double? Value { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

    }
}
