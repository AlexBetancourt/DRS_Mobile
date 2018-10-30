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
            database.CreateTableAsync<Pilot>().Wait();
            database.CreateTableAsync<LocationArmor>().Wait();
            database.CreateTableAsync<LocationSlots>().Wait();
            //database.CreateTableAsync<List<LocationSlots>>().Wait();

            database.CreateTableAsync<LocationInternal>().Wait();
//            database.CreateTableAsync<MechLocations>().Wait();
            database.CreateTableAsync<Mech>().Wait();
            database.CreateTableAsync<MechConfigurations>().Wait();
            database.CreateTableAsync<AmmoItems>().Wait();
            database.CreateTableAsync<EquipmentItems>().Wait();
            database.CreateTableAsync<MechForces>().Wait();
            database.CreateTableAsync<MissionTypes>().Wait();
            database.CreateTableAsync<ForceMissions>().Wait();
            database.CreateTableAsync<ForceMechs>().Wait();

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
