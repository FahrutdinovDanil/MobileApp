using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileApp.Sqlite
{
    public class ImagesRepository
    {
        SQLiteConnection database;
        public ImagesRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Photo>();
        }

        public IEnumerable<Photo> GetItems()
        {
            return database.Table<Photo>().ToList();
        }

        public Photo GetItem(int id)
        {
            return database.Get<Photo>(id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Photo>(id);
        }

        public int SaveItem(Photo item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
