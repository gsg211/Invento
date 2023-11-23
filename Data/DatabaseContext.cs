using SQLite;

namespace Inventory_maui.Data
{
    public class DatabaseContext
    {
        string _dbPath;
        SQLiteConnection conn;
        //private const string DbName = "ItemDatabase.db";
        //private static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DbName);
        //private SQLiteConnection _connection;

        public DatabaseContext (string Path)
        {
            _dbPath = Path;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Item>();
        }

        public List<Item> GetAllitems()
        {
            Init();
            return conn.Table<Item>().ToList();
        }

        public void Add(Item newItem)
        {
            conn=new SQLiteConnection(_dbPath);
            conn.Insert(newItem);
        }

        public void RemoveById(int Id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(Id);
        }
    }
}
