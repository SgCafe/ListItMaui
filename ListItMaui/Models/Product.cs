using SQLite;

namespace ListIt_Maui.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public decimal? Value { get; set; }
        public CategoryType Category { get; set; }
        public string Image { 
            get => ImageConstants.CategoryImageMap[Category];
            set { }
        }

    }
}
