using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using DRS_Mobile.Models;

namespace DRS_Mobile.Data
{
    public class MechDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MechDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Mech>().Wait();
        }

        public Task<List<Mech>> GetItemsAsync()
        {
            return database.Table<Mech>().ToListAsync();
        }

        public Task<List<Mech>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Mech>("SELECT * FROM [Mech] WHERE [Done] = 0");
        }

        public Task<Mech> GetItemAsync(int id)
        {
            return database.Table<Mech>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Mech item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Mech item)
        {
            return database.DeleteAsync(item);
        }
    }
}
