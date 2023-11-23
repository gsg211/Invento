using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Inventory_maui
{
    public class PersonRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
            {
                return;
            }
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Item>();
        }

        public PersonRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewPerson(Item NewItem)
        {
            int result = 0;
            try
            {
                Init();


                result = conn.Insert(NewItem);

                StatusMessage = string.Format("Added new item");
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add item. Error: {1}", ex.Message);
            }

        }

        public List<Item> GetAllItems()
        {
            // TODO: Init then retrieve a list of Person objects from the database into a list
            try
            {
                Init();
                return conn.Table<Item>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Item>();
        }
    }
}
