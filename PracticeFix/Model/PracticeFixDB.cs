using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PracticeFix;

namespace PracticeFix.Model
{
    public class PracticeFixDB
    {
        readonly SQLiteAsyncConnection db;
        public PracticeFixDB(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<PracticeFix>().Wait();
        }

        public Task<List<PracticeFix>> GetPracticeFixAsync()
        {
            //get all practiceFix.
            return db.Table<PracticeFix>().ToListAsync();

            /*第二種寫法 GetPracticeFixNotDoneAsync*/
            //return db.QueryAsync<PracticeFix>("select * from [PracticeFix] where [Id] = 0");
        }

        public Task<int> SavePracticeFixAsync(PracticeFix practiceFix)
        {
            if (practiceFix.Item_Id != 0)
            {
                //update existing practicefix
                return db.UpdateAsync(practiceFix);
            }
            else
            {
                //save a new practicedix
                return db.UpdateAsync(practiceFix);
            }
        }

        public Task<int> DeletePracticeFixAsync(PracticeFix practiceFix)
        {
            //delete existing practicefix
            return db.DeleteAsync(practiceFix);
        }
    }
}
