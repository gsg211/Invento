using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Inventory_maui
{
    [Table("items")]
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [MaxLength(250), Unique]
        public int Quantity { get; set; }

        [MaxLength(250), Unique]
        public int Stock { get; set; }

        [MaxLength(250), Unique]
        public int Price { get; set; }

        [MaxLength(250), Unique]
        public int ProductionCost { get; set; }

        [MaxLength(250), Unique]
        public int Profit { get; set; }

    }
}
