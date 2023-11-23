using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_maui
{
    public class DatabaseHandler
    {

        private SQLiteConnection _db;

        public DatabaseHandler()
        {

            _db = new SQLiteConnection("models/Items.cs");
            _db.CreateTable<Item>();
        }
    }
}
